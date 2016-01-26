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
        List<DistributerDTO> listaDistributera;
        List<FilmDTO> listaFilmova;

        public AdministratorForm()
        {
            InitializeComponent();

            popuniListuZaposlenih();
            popuniListuDistributera();
            popuniListuFilmova();
            
            ZaposleniDTO zaposleni = BioskopUtil.getPrijavljeniZaposleni();
            lblImePrezime.Text = zaposleni.Ime + " " + zaposleni.Prezime;

            groupBox1.Hide();
            hideDistributer();
        }

        private void hideDistributer()
        {
            gboxDetaljiDistributer.Hide();
            dgvFilmovi.Hide();
            lblFilmoviStatic.Hide();
        }

        private void showDistributer()
        {
            gboxDetaljiDistributer.Show();
            dgvFilmovi.Show();
            lblFilmoviStatic.Show();
        }


        private void popuniListuZaposlenih()
        {
            lvZaposleni.Items.Clear();
            listaOsoba = BioskopUtil.getDAOFactory().getZaposleniDAO().getAll();
            foreach (ZaposleniDTO zaposleni in listaOsoba)
            {
                ListViewItem lvi=new ListViewItem();
                lvi.Name = zaposleni.Id.ToString();

                lvi.Text = zaposleni.KorisnickoIme;
                lvi.SubItems.Add(zaposleni.Ime);
                lvi.SubItems.Add(zaposleni.Prezime);
                lvZaposleni.Items.Add(lvi);
            }
        }

        private void popuniListuDistributera()
        {
            lvDistributeri.Items.Clear();
            listaDistributera = BioskopUtil.getDAOFactory().getDistributerDAO().getAll();
            foreach (DistributerDTO distributer in listaDistributera)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Name = distributer.Id.ToString();
                lvi.Text = distributer.Naziv;

                lvDistributeri.Items.Add(lvi);
            }
        }

        private void popuniListuFilmova()
        {
            lvFilmovi.Items.Clear();
            listaFilmova = BioskopUtil.getDAOFactory().getFilmDAO().getAll();
            foreach (FilmDTO film in listaFilmova)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Name = film.Id.ToString();
                lvi.Text = film.Naziv;

                lvFilmovi.Items.Add(lvi);
            }
        }

        private void popuniListuFilmova(string naziv)
        {
            lvFilmovi.Items.Clear();
            listaFilmova = BioskopUtil.getDAOFactory().getFilmDAO().searchByNaziv(naziv);
            foreach (FilmDTO film in listaFilmova)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Name = film.Id.ToString();
                lvi.Text = film.Naziv;

                lvFilmovi.Items.Add(lvi);
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

        private bool dodajFilm()
        {
            FilmDodajForm f = new FilmDodajForm();
            return (f.ShowDialog() == DialogResult.OK);
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

        private void prikaziDetalje(DistributerDTO distributer)
        {
            lblNazivDist.Text = distributer.Naziv;
            lblAdresaDist.Text = distributer.Adresa;
            lblEmailDist.Text = distributer.Email;
            lblBrojTelefonaDist.Text = distributer.Telefon;
            
            List<FilmDTO> filmovi = BioskopUtil.getDAOFactory().getFilmDAO().getAllByDistributer(distributer);
            dgvFilmovi.Rows.Clear();
            foreach (FilmDTO film in filmovi)
            {
                dgvFilmovi.Rows.Add(film.Naziv, film.Zanr.Naziv, film.Trajanje, film.Status.Naziv);
            }
            
            showDistributer();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (dodajZaposlenog())
            {
                popuniListuZaposlenih();
            }
        }

        private void btnDodajDistributera_Click(object sender, EventArgs e)
        {
            if (dodajDistributera())
            {
                popuniListuDistributera();
            }
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

        private void btnDodajFilm_Click(object sender, EventArgs e)
        {
            if (dodajFilm())
            {
                popuniListuFilmova();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            BioskopUtil.odjavaZaposleni();
            this.DialogResult = DialogResult.OK;
            
        }

        private void lvDistributeri_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (lvDistributeri.SelectedIndices.Count == 0)
            {
                gboxDetaljiDistributer.Hide();
                hideDistributer();
                return;
            }
            prikaziDetalje(listaDistributera[lvDistributeri.FocusedItem.Index]);
        }

        private void tbxPretragaFilma_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxPretragaFilma.Text))
            {
                popuniListuFilmova();
                return;
            }

            popuniListuFilmova(tbxPretragaFilma.Text);
        }

        private void btnIzmjeniZaposleni_Click(object sender, EventArgs e)
        {
            ZaposleniKreiranjeForm kreiranje = new ZaposleniKreiranjeForm(listaOsoba[lvZaposleni.FocusedItem.Index]);
            if (kreiranje.ShowDialog() == DialogResult.OK)
            {
                popuniListuZaposlenih();
            }
        }

        private void btnOtkaz_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Da li ste sigurni?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void btnIzmjeniDistributer_Click(object sender, EventArgs e)
        {
            DistributerDodajForm kreiranje = new DistributerDodajForm(listaDistributera[lvDistributeri.FocusedItem.Index]);
            if (kreiranje.ShowDialog() == DialogResult.OK)
            {
                popuniListuDistributera();
            }
        }

        private void btnDodajSalu_Click(object sender, EventArgs e)
        {
            SalaDodajForm sdf = new SalaDodajForm();
            sdf.ShowDialog();

        }


    }
}
