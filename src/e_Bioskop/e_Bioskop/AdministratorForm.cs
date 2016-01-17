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
            groupBox1.Hide();
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

        private void prikaziDetalje(ZaposleniDTO zaposleni)
        {
            lblIme.Text = zaposleni.Ime;
            lblPrezime.Text = zaposleni.Prezime;
            lblEmail.Text = zaposleni.Email;
            lblTelefon.Text = zaposleni.Telefon;
            List<ZaposleniRadnoMjestoDTO> zaposleniRadnoMjesto = BioskopUtil.getDAOFactory().getZaposleniRadnoMjestoDAO().getRadnaMjestaZaposlenog(zaposleni);
            foreach (ZaposleniRadnoMjestoDTO z in zaposleniRadnoMjesto)
            {
                lblDatumZaposlenja.Text = z.DatumZaposlenja.ToShortDateString();
                lblRadnoMjesto.Text = z.RadnoMjesto.Naziv;
            }
            if (zaposleni.Aktivan == 1)
            {
                picAktivan.Image = Properties.Resources.zeleno;
            }
            else
            {
                picAktivan.Image = Properties.Resources.crveno;
            }
            groupBox1.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            dodajZaposlenog();
        }

        private void btnDodajDistributera_Click(object sender, EventArgs e)
        {
            dodajDistributera();
        }

        private void lvZaposleni_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvZaposleni.SelectedIndices.Count == 0)
            {
                groupBox1.Hide();
                return;
            }
            prikaziDetalje (listaOsoba[lvZaposleni.FocusedItem.Index]);
        }

    }
}
