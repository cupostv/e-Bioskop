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
    public partial class PrijavaForm : Form
    {
        public PrijavaForm()
        {
            InitializeComponent();
            lblGreska.Visible = false;
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                ZaposleniDTO zaposleni = BioskopUtil.getPrijavljeniZaposleni();
                ZaposleniRadnoMjestoDTO zaposleniRM = (BioskopUtil.getDAOFactory().getZaposleniRadnoMjestoDAO().getRadnaMjestaZaposlenog(zaposleni))[0];
                if (zaposleniRM.RadnoMjesto.Naziv == "Upravnik")
                {
                    
                    UpravnikForm administrator = new UpravnikForm();
                    this.Hide();
                    if ((new UpravnikForm().ShowDialog()) == DialogResult.OK)
                    {
                        Refresh();
                    }
                    
                }
                else if (zaposleniRM.RadnoMjesto.Naziv == "Administrator")
                {
                    AdministratorForm administrator = new AdministratorForm();
                    this.Hide();
                    if ((new AdministratorForm().ShowDialog()) == DialogResult.OK)
                    {
                        Refresh();
                    }
                }
                else
                {
                    if (zaposleniRM.RadnoMjesto.Naziv == "Radnik")
                    {
                        ZaposleniForm administrator = new ZaposleniForm();
                        this.Hide();
                        if ((new ZaposleniForm().ShowDialog()) == DialogResult.OK)
                        {
                            Refresh();
                        }
                    }
                }

            }
            else
            {
                lblGreska.Visible = true;
            }
        }

        private bool validate()
        {
            if (string.IsNullOrEmpty(tbxKorisnickoIme.Text) || string.IsNullOrEmpty(tbxLozinka.Text))
            {
                lblGreska.Text = "Pogrešno korisničko ime i/ili lozinka";
                return false;
            }

            ZaposleniDTO zaposleni = BioskopUtil.getDAOFactory().getZaposleniDAO().getByUsername(tbxKorisnickoIme.Text);
            if (zaposleni == null)
            {
                lblGreska.Text = "Pogrešno korisničko ime i/ili lozinka";
                return false;
            }

            if (BioskopUtil.sha256(tbxLozinka.Text) != zaposleni.Lozinka)
            {
                lblGreska.Text = "Pogrešno korisničko ime i/ili lozinka";
                return false;
            }

            if (zaposleni.Aktivan == 0)
            {
                lblGreska.Text = "Ovaj nalog je neaktivan, ne možete se prijaviti na sistem.";
                return false;
            }

            BioskopUtil.prijavaZaposleni(zaposleni);
            
            return true;
        }

        private void Refresh()
        {
            tbxKorisnickoIme.Text = "";
            tbxLozinka.Text = "";
            lblGreska.Hide();
            tbxKorisnickoIme.Focus();
            this.Show();
        }

        private void PrijavaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


    }
}
