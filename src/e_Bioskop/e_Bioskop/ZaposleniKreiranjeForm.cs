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
        string opciono = "Opciono";

        public ZaposleniKreiranjeForm()
        {
            InitializeComponent();
            txbEmail.Text = opciono;
            txbEmail.ForeColor = SystemColors.GrayText;
            BioskopUtil.initRadnoMjestoComboBox(cboxRadnoMjesto, -1);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (insertZaposleni())
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
            }
            else
            {
                epRadnoMjesto.Clear();
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
    }
}
