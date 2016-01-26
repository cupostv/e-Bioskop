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
    public partial class ProjekcijaDodajForm : Form
    {
        private FilmDTO film = null;
        private bool izmjena = false;
        private ProjekcijaDTO projekcija = null;
        public ProjekcijaDodajForm()
        {
            InitializeComponent();
            dtpVrijeme.CustomFormat = "hh:mm";
            gbIzabraniFilm.Hide();
            BioskopUtil.initSalaDTOComboBox(cbSala, -1);
            
        }

        public ProjekcijaDodajForm(ProjekcijaDTO projekcija)
        {
            InitializeComponent();
            dtpVrijeme.CustomFormat = "hh:mm";
            this.film = projekcija.Film;
            showFilmData();
            projekcijaDTOToControlls(projekcija);
            izmjena = true;
            this.projekcija = projekcija;
        }

        private void projekcijaDTOToControlls(ProjekcijaDTO projekcija)
        {
            dtpDatum.Value = projekcija.Vrijeme.Date;
            dtpVrijeme.Value =projekcija.Vrijeme;
            tbxCijena.Text = projekcija.Cijena.ToString();
            BioskopUtil.initSalaDTOComboBox(cbSala, projekcija.Sala.Id);
        }

        private void btnIzborFilma_Click(object sender, EventArgs e)
        {
            FilmIzborForm fif = new FilmIzborForm();
            if (fif.ShowDialog() == DialogResult.OK)
            {
                film = fif.SelektovaniFilm;
                showFilmData();
            }
            else
            {
                gbIzabraniFilm.Hide();
                film = null;
            }
        }


        private void showFilmData()
        {
            gbIzabraniFilm.Show();
            lblNazivFilma.Text = film.Naziv;
            lblOpisFilma.Text = film.Opis;
            lblTrajanjeFilma.Text = film.Trajanje + " minuta";
            lblZanrFilma.Text = film.Zanr.Naziv;
        }

        private ProjekcijaDTO getProjekcijaFromControlls()
        {
            ProjekcijaDTO projekcija = new ProjekcijaDTO();
            projekcija.Film = film;
            projekcija.Sala = BioskopUtil.getSalaFromComboBox(cbSala);
            projekcija.Vrijeme = dtpDatum.Value.Date + dtpVrijeme.Value.TimeOfDay;
            projekcija.Cijena = int.Parse(tbxCijena.Text);
            return projekcija;
        }

        private bool insertProjekcija()
        {
            ProjekcijaDTO projekcija = getProjekcijaFromControlls();
            long id=BioskopUtil.getDAOFactory().getProjekcijaDAO().insert(projekcija);
            if (id > 0)
            {
                projekcija.Id = (int)id;
                return true;
            }
            else
            {
                if (MessageBox.Show(this, "Došlo je do greške, molimo Vas da pokušate ponovo.", "Greška", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)==DialogResult.Retry)
                {
                    return insertProjekcija();
                }
                else
                {
                    return false;
                }
            }

        }

        private bool updateProjekcija()
        {
            ProjekcijaDTO projekcija = getProjekcijaFromControlls();
            projekcija.Id = this.projekcija.Id;
            if (BioskopUtil.getDAOFactory().getProjekcijaDAO().update(projekcija))
            {
                return true;
            }
            else
            {
                if (MessageBox.Show(this, "Došlo je do greške, molimo Vas da pokušate ponovo.", "Greška", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1) == DialogResult.Retry)
                {
                    return updateProjekcija();
                }
                else
                {
                    return false;
                }
            }

        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (izmjena)
            {
                if (updateProjekcija())
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    this.DialogResult = DialogResult.Abort;
                    this.Close();
                }
            }
            else
            {
                if (insertProjekcija())
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    this.DialogResult = DialogResult.Abort;
                    this.Close();
                }
            }
        }
    }
}
