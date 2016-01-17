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
    public partial class AdministratorForm : Form
    {
        List<ZaposleniDTO> listaOsoba;
        public AdministratorForm()
        {
            InitializeComponent();
            popuniListuZaposlenih();
            ZaposleniDTO zaposleni = BioskopUtil.getPrijavljeniZaposleni();
            lblImePrezime.Text = zaposleni.Ime + " " + zaposleni.Prezime;
        }


        private void popuniListuZaposlenih()
        {
            listaOsoba = BioskopUtil.getDAOFactory().getZaposleniDAO().getAll();
            foreach (ZaposleniDTO zaposleni in listaOsoba)
            {
                ListViewItem lvi=new ListViewItem();
                lvi.Name = zaposleni.Id + "";

                lvi.Text = zaposleni.KorisnickoIme;
                lvi.SubItems.Add(zaposleni.Ime);
                lvi.SubItems.Add(zaposleni.Prezime);
                lvZaposleni.Items.Add(lvi);
            }
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            
        }

        private void odjava()
        {
            BioskopUtil.odjavaZaposleni();
            this.Close();
            PrijavaForm prijava = new PrijavaForm();
            prijava.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            dodajZaposlenog();
        }

        private  bool dodajZaposlenog()
        {
            ZaposleniKreiranjeForm kreiranje = new ZaposleniKreiranjeForm();
            return (kreiranje.ShowDialog() == DialogResult.OK);
        }

        private bool dodajDistributera()
        {
            DistributerDodajForm ddf = new DistributerDodajForm();
            return (ddf.ShowDialog() == DialogResult.OK);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            dodajZaposlenog();
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            dodajDistributera();
        }

    }
}
