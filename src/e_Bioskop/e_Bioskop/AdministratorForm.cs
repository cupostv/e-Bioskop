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

            gboxDistributer.Hide();
            gboxFilm.Hide();

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
                dgvFilmovi.Rows.Add(film.Naziv, film.Zanr.Naziv, film.Trajanje, film.Status.Naziv, film.Id);
            }
            
            showDistributer();
        }

        private void prikaziDetalje(FilmDTO film)
        {
            lblNazivFilm.Text = film.Naziv;
            lblFilmTrajanje.Text = film.Trajanje.ToString();
            lblFilmZanr.Text = film.Zanr.Naziv;
            lblFilmStatus.Text = film.Status.Naziv;
            lblFilmOpis.Text = film.Opis;
            lblDistFilmNaziv.Text = film.Distributer.Naziv;
            lblDistFilmEmail.Text = film.Distributer.Email;
            lblDistFilmBrojTelefona.Text = film.Distributer.Telefon;
            lblDistFilmAdresa.Text = film.Distributer.Adresa;

            gboxFilm.Show();
            gboxDistributer.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (dodajZaposlenog())
            {
                popuniListuZaposlenih();
                groupBox1.Hide();
            }
        }

        private void btnDodajDistributera_Click(object sender, EventArgs e)
        {
            if (dodajDistributera())
            {
                popuniListuDistributera();
                hideDistributer();
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
                gboxFilm.Hide();
                gboxDistributer.Hide();
                tbxPretragaFilma.Clear();
            }
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            BioskopUtil.odjavaZaposleni();
            this.DialogResult = DialogResult.OK;
            this.Close();
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
                gboxDistributer.Hide();
                gboxFilm.Hide();
                return;
            }
            gboxDistributer.Hide();
            gboxFilm.Hide();
            popuniListuFilmova(tbxPretragaFilma.Text);
        }

        private void btnIzmjeniZaposleni_Click(object sender, EventArgs e)
        {
            if (lvZaposleni.SelectedIndices.Count == 0)
            {
                return;
            }
            ZaposleniKreiranjeForm kreiranje = new ZaposleniKreiranjeForm(listaOsoba[lvZaposleni.FocusedItem.Index]);
            if (kreiranje.ShowDialog() == DialogResult.OK)
            {
                int index = lvZaposleni.FocusedItem.Index;
                ZaposleniDTO izmjenjeni = BioskopUtil.getDAOFactory().getZaposleniDAO().getById(listaOsoba[index].Id);

                listaOsoba[index] = izmjenjeni;

                ListViewItem lvi = new ListViewItem();
                lvi.Name = izmjenjeni.Id.ToString();
                lvi.Text = izmjenjeni.KorisnickoIme;
                lvi.SubItems.Add(izmjenjeni.Ime);
                lvi.SubItems.Add(izmjenjeni.Prezime);

                lvZaposleni.Items.RemoveByKey(izmjenjeni.Id.ToString());
                lvZaposleni.Items.Insert(index, lvi);

                lvZaposleni.FocusedItem = lvi;
                lvZaposleni.Items[index].Selected = true;


                prikaziDetalje(listaOsoba[index]);
                
                //popuniListuZaposlenih();
            }
        }

        private void btnOtkaz_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ZaposleniDTO zaposleni = listaOsoba[lvZaposleni.FocusedItem.Index];
                zaposleni.Aktivan = 0;
                ZaposleniRadnoMjestoDTO zaposleniRadnoMjesto = (BioskopUtil.getDAOFactory().getZaposleniRadnoMjestoDAO().getRadnaMjestaZaposlenog(zaposleni))[0];
                zaposleniRadnoMjesto.DatumOtkaza = DateTime.Today;
                zaposleniRadnoMjesto.Zaposleni = zaposleni;
                BioskopUtil.getDAOFactory().getZaposleniDAO().update(zaposleniRadnoMjesto.Zaposleni);
                BioskopUtil.getDAOFactory().getZaposleniRadnoMjestoDAO().update(zaposleniRadnoMjesto, zaposleniRadnoMjesto.RadnoMjesto.Id);
            }
        }

        private void btnIzmjeniDistributer_Click(object sender, EventArgs e)
        {
            if (lvDistributeri.SelectedIndices.Count == 0)
            {
                return;
            }
            int index = lvDistributeri.FocusedItem.Index;
            DistributerDodajForm kreiranje = new DistributerDodajForm(listaDistributera[index]);
            
            if (kreiranje.ShowDialog() == DialogResult.OK)
            {
                popuniListuDistributera();
                lvDistributeri.FocusedItem = lvDistributeri.Items[index];
                lvDistributeri.Items[index].Selected = true;

                prikaziDetalje(listaDistributera[index]);
            }
        }

        private void lvFilmovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvFilmovi.SelectedIndices.Count == 0)
            {
                gboxDistributer.Hide();
                gboxFilm.Hide();
                return;
            }
            prikaziDetalje(listaFilmova[lvFilmovi.FocusedItem.Index]);
        }

        private void btnIzmjeniFilm_Click(object sender, EventArgs e)
        {
            if (lvFilmovi.SelectedIndices.Count == 0)
            {
                return;
            }

            FilmDodajForm kreiranje = new FilmDodajForm(listaFilmova[lvFilmovi.FocusedItem.Index]);
            
            if (kreiranje.ShowDialog() == DialogResult.OK)
            {
                
                int index = lvFilmovi.FocusedItem.Index;
                FilmDTO izmjenjeni = BioskopUtil.getDAOFactory().getFilmDAO().getById(listaFilmova[index].Id);

                listaFilmova[index] = izmjenjeni;

                ListViewItem lvi = new ListViewItem();
                lvi.Name = izmjenjeni.Id.ToString();
                lvi.Text = izmjenjeni.Naziv;

                lvFilmovi.Items.RemoveByKey(izmjenjeni.Id.ToString());
                lvFilmovi.Items.Insert(index, lvi);

                lvFilmovi.FocusedItem = lvi;
                lvFilmovi.Items[index].Selected = true;
                

                prikaziDetalje(listaFilmova[index]);
                
            }
        }

        private void btnFilmDistIzmjeni_Click(object sender, EventArgs e)
        {
            if (lvFilmovi.SelectedIndices.Count == 0)
            {
                return;
            }
            
            
            DistributerDodajForm kreiranje = new DistributerDodajForm(listaFilmova[lvFilmovi.FocusedItem.Index].Distributer);
            if (kreiranje.ShowDialog() == DialogResult.OK)
            {
                int index = lvFilmovi.FocusedItem.Index;
                ListViewItem lvi = lvFilmovi.FocusedItem;

                lvFilmovi.FocusedItem = lvFilmovi.Items[index];
                lvFilmovi.Items[index].Selected = true;

                prikaziDetalje(listaFilmova[index]);

                popuniListuDistributera();
            }
        }

        private void dgvFilmovi_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = dgvFilmovi.HitTest(e.X, e.Y).RowIndex;
                
                if (currentMouseOverRow >= 0)
                {
                    foreach (DataGridViewRow row in dgvFilmovi.Rows)
                    {
                        row.Selected = false;
                    }
                    dgvFilmovi.Rows[currentMouseOverRow].Selected = true;         
                    cmsFilmDistributer.Show(dgvFilmovi, new Point(e.X, e.Y));
                }

            }
        }

        private void izmjeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = (int)dgvFilmovi.SelectedRows[0].Cells[4].Value;
            FilmDTO film = BioskopUtil.getDAOFactory().getFilmDAO().getById(id);

            FilmDodajForm kreiranje = new FilmDodajForm(film);

            if (kreiranje.ShowDialog() == DialogResult.OK)
            {
                popuniListuFilmova();
                gboxDistributer.Hide();
                gboxFilm.Hide();
                prikaziDetalje(listaDistributera[lvDistributeri.FocusedItem.Index]);
            }
        }

        private void AdministratorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (BioskopUtil.getPrijavljeniZaposleni() != null)
            {
                Application.Exit();
            }
        }

        private void btnDodajSalu_Click(object sender, EventArgs e)
        {
            SalaDodajForm sala = new SalaDodajForm();
            if (sala.ShowDialog() == DialogResult.OK)
            {

            }
        }

    }
}
