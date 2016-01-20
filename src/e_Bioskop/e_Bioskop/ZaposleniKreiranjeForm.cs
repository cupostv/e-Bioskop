using e_Bioskop.data.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace e_Bioskop
{
    public partial class ZaposleniKreiranjeForm : Form
    {
        private string opciono = "Opciono";
        private bool izmjena;
        private ZaposleniRadnoMjestoDTO zaposleni = null;

        public ZaposleniKreiranjeForm()
        {
            InitializeComponent();
            txbEmail.Text = opciono;
            txbEmail.ForeColor = SystemColors.GrayText;
            BioskopUtil.initRadnoMjestoComboBox(cboxRadnoMjesto, -1);
            txbLozinka.TextChanged += new EventHandler(txbLozinka1_TextChanged);
        }

        public ZaposleniKreiranjeForm(ZaposleniDTO zaposleni)
        {
            InitializeComponent();

            txbLozinka.TextChanged += new EventHandler(txbLozinka1_TextChanged);

            ZaposleniRadnoMjestoDTO zaposleniRM = (BioskopUtil.getDAOFactory().getZaposleniRadnoMjestoDAO().getRadnaMjestaZaposlenog(zaposleni))[0];
            txbIme.Text = zaposleni.Ime;
            txbPrezime.Text = zaposleni.Prezime;
            txbKorisnickoIme.Text = zaposleni.KorisnickoIme;
            txbEmail.Text = zaposleni.Email;
            txbBrojTelefona.Text = zaposleni.Telefon;
            BioskopUtil.initRadnoMjestoComboBox(cboxRadnoMjesto, zaposleniRM.RadnoMjesto.Id);
            cbAktivan.Checked = zaposleni.Aktivan == 1 ? true : false;
            dtpDatumRodjenja.Value = zaposleni.DatumRodjenja;
            dtpDatumZaposlenja.Value = zaposleniRM.DatumZaposlenja;
            this.zaposleni = zaposleniRM;
            this.Text = "Izmjena naloga";
           
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (zaposleni == null)
            {
                if (insertZaposleni())
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    return;
                }
            }
            if (updateZaposleni())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool validate()
        {
            bool valid = true;
            if (string.IsNullOrEmpty(txbIme.Text))
            {
                epNaziv.SetError(txbIme, "Unesite ime");
                valid = false;
            }
            else
            {
                epNaziv.Clear();
            }

            if (string.IsNullOrEmpty(txbBrojTelefona.Text))
            {
                epBrojTelefona.SetError(txbBrojTelefona, "Unesite broj telefona");
                valid = false;
            }
            else
            {
                epBrojTelefona.Clear();
            }

            if (string.IsNullOrEmpty(txbPrezime.Text))
            {
                epPrezime.SetError(txbPrezime, "Unesite prezime");
                valid = false;
            }
            else
            {
                epPrezime.Clear();
            }

            if (cboxRadnoMjesto.SelectedIndex == -1)
            {
                epRadnoMjesto.SetError(cboxRadnoMjesto, "Izaberite radno mjesto");
                valid = false;
            }
            else
            {
                epRadnoMjesto.Clear();
            }
            if (string.IsNullOrEmpty (txbKorisnickoIme.Text))
            {
                epKorisnickoIme.SetError (txbKorisnickoIme, "Unesite korisničko ime");
                valid = false;
            }
            else
            {
                if (!validateKorisnickoIme(txbKorisnickoIme.Text))
                {
                    epKorisnickoIme.SetError(txbKorisnickoIme, "Korisničko ime zauzeto");
                    valid = false;
                }
                else
                {
                    epKorisnickoIme.Clear();
                }
               
            }
            
            if (string.IsNullOrEmpty(txbLozinka.Text))
            {
                epLozinka.SetError(txbLozinka, "Unesite lozinku");
                valid = false;
            }
            else
            {
                epLozinka.Clear();
            }

            if (txbLozinka.Text != txbLozinka1.Text)
            {
                epLozinka1.SetError(txbLozinka1, "Lozinke se ne podudaraju");
                valid = false;
            }
            else
            {
                epLozinka1.Clear();
            }
            


            return valid;
        }

        private ZaposleniRadnoMjestoDTO controlsToZaposleni()
        {
            ZaposleniDTO zaposleni = new ZaposleniDTO();
            zaposleni.Ime = txbIme.Text;
            zaposleni.Prezime = txbPrezime.Text;
            zaposleni.Lozinka=BioskopUtil.sha256(txbLozinka.Text);
            zaposleni.Telefon = txbBrojTelefona.Text;
            zaposleni.KorisnickoIme = txbKorisnickoIme.Text;
            zaposleni.DatumRodjenja = dtpDatumRodjenja.Value;
            zaposleni.Email = txbEmail.ForeColor == SystemColors.GrayText ? "" : txbEmail.Text;
            zaposleni.Aktivan = cbAktivan.Checked ? 1 : 0;
            ZaposleniRadnoMjestoDTO zaposleniRadnoMjesto = new ZaposleniRadnoMjestoDTO();

            zaposleniRadnoMjesto.RadnoMjesto = BioskopUtil.getRadnoMjestoFromComboBox(cboxRadnoMjesto);
            zaposleniRadnoMjesto.Zaposleni = zaposleni;
            zaposleniRadnoMjesto.DatumZaposlenja = dtpDatumZaposlenja.Value;
            zaposleniRadnoMjesto.DatumOtkaza = dtpDatumZaposlenja.Value;

            return zaposleniRadnoMjesto;
        }

        private bool insertZaposleni()
        {
            if (validate())
            {
                ZaposleniRadnoMjestoDTO zaposleniRadnoMjesto = controlsToZaposleni();
                long id=BioskopUtil.getDAOFactory().getZaposleniDAO().insert(zaposleniRadnoMjesto.Zaposleni);
                if (id > 0)
                {
                    zaposleniRadnoMjesto.Zaposleni.Id = (int)id;
                    return BioskopUtil.getDAOFactory().getZaposleniRadnoMjestoDAO().insert(zaposleniRadnoMjesto);
                }
            }
           return false;
        }

        private bool updateZaposleni()
        {
            if (validate())
            {
                BioskopUtil.getDAOFactory().getZaposleniRadnoMjestoDAO().update(zaposleni);
                return true;
            }
            return false;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txbEmail_Enter(object sender, EventArgs e)
        {
            if (txbEmail.ForeColor != SystemColors.GrayText)
            {
                return;
            }
            txbEmail.Text = "";
            txbEmail.ForeColor = SystemColors.WindowText;
        }

        private void txbEmail_Leave(object sender, EventArgs e)
        {
            if (txbEmail.Text == "")
            {
                txbEmail.Text = opciono;
                txbEmail.ForeColor = SystemColors.GrayText;
            }
        }

        private void txbKorisnickoIme_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbKorisnickoIme.Text))
            {
                return;
            }
            if (BioskopUtil.getDAOFactory().getZaposleniDAO().getByUsername(txbKorisnickoIme.Text) != null)
            {
                epKorisnickoIme.SetError(txbKorisnickoIme, "Korisničko ime zauzeto");
            }
            else
            {
                epKorisnickoIme.Clear();
            }
        }

        private bool validateKorisnickoIme(string korisnickoIme)
        {
            if (BioskopUtil.getDAOFactory().getZaposleniDAO().getByUsername(korisnickoIme) != null)
            {
                return false;
            }
            return true;
        }

        private void txbLozinka1_TextChanged(object sender, EventArgs e)
        {
            if (txbLozinka.Text != txbLozinka1.Text)
            {
                epLozinka1.SetError(txbLozinka1, "Lozinke se ne podudaraju");
            }
            else
            {
                epLozinka1.Clear();
            }
        }
    }
}
