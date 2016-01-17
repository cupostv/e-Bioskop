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
        public ZaposleniKreiranjeForm()
        {
            InitializeComponent();
            
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
            if (string.IsNullOrWhiteSpace(txbLozinka.Text))
                return false;
            if (string.IsNullOrWhiteSpace(txbKorisnickoIme.Text))
                return false;
            if (txbLozinka.Text.Equals(txbLozinka.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private ZaposleniDTO controlsToZaposleni()
        {
            ZaposleniDTO zaposleni = new ZaposleniDTO();
            zaposleni.Ime = txbIme.Text;
            zaposleni.Prezime = txbPrezime.Text;
            zaposleni.Lozinka=BioskopUtil.sha256(txbLozinka.Text);
            zaposleni.Telefon = txbBrojTelefona.Text;
            zaposleni.KorisnickoIme = txbKorisnickoIme.Text;
            zaposleni.DatumRodjenja = dtpDatumRodjenja.Value;
            zaposleni.Email = txbEmail.Text;
            return zaposleni;
        }

        private bool insertZaposleni()
        {
            if (validate())
            {
                ZaposleniDTO zaposleni = controlsToZaposleni();
                long id=BioskopUtil.getDAOFactory().getZaposleniDAO().insert(zaposleni);
                if (id > 0)
                    return true;
            }
           return false;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
