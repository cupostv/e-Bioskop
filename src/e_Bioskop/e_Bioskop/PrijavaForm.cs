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
                        tbxKorisnickoIme.Text = "";
                        tbxLozinka.Text = "";
                        this.Show();
                    }
                }
                else if (zaposleniRM.RadnoMjesto.Naziv == "Administrator")
                {
                    AdministratorForm administrator = new AdministratorForm();
                    this.Hide();
                    if ((new AdministratorForm().ShowDialog()) == DialogResult.OK)
                    {
                        tbxKorisnickoIme.Text = "";
                        tbxLozinka.Text = "";
                        lblGreska.Hide();
                        tbxKorisnickoIme.Focus();

                        this.Show();
                    }
                }
                else
                {

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
                return false;
            }

            ZaposleniDTO zaposleni = BioskopUtil.getDAOFactory().getZaposleniDAO().getByUsername(tbxKorisnickoIme.Text);
            if (zaposleni == null)
            {
                return false;
            }

            if (BioskopUtil.sha256(tbxLozinka.Text) != zaposleni.Lozinka)
            {
                return false;
            }

            BioskopUtil.prijavaZaposleni(zaposleni);
            
            return true;
        }

        private void PrijavaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


    }
}
