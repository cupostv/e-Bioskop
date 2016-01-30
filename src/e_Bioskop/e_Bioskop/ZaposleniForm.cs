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
    public partial class ZaposleniForm : Form
    {
        private ProjekcijaDTO izabranaProjekcija;

        public ZaposleniForm()
        {
            InitializeComponent();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {

        }

        private void btnDodajDistributera_Click(object sender, EventArgs e)
        {

        }

        private void btnDodajFilm_Click(object sender, EventArgs e)
        {

        }

        private void btnIzborProjekcije_Click(object sender, EventArgs e)
        {
            ProjekcijaIzborForm pif = new ProjekcijaIzborForm();
            if (pif.ShowDialog() == DialogResult.OK)
            {
                izabranaProjekcija = pif.IzabranaProjekcija;
            }
        }

        private void btnOdjava_Click_1(object sender, EventArgs e)
        {
            BioskopUtil.odjavaZaposleni();
            this.Close();
            PrijavaForm prijava = new PrijavaForm();
            prijava.Show();
        }
    }
}
