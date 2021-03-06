﻿using e_Bioskop.data.dto;
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
            BioskopUtil.initSalaDTOComboBox(cbSala, -1);
            
        }

        public ProjekcijaDodajForm(ProjekcijaDTO projekcija)
        {
            InitializeComponent();
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
            projekcija.Cijena = float.Parse(tbxCijena.Text);
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

        private bool validate()
        {
            bool valid = true;

            if (cbSala.SelectedIndex < 0)
            {
                epSala.SetError(cbSala, "Izaberite salu");
                valid = false;
            }
            else
            {
                epSala.Clear();
            }

            if (string.IsNullOrEmpty(tbxCijena.Text.Trim()))
            {
                epCijena.SetError(tbxCijena, "Unesite cijenu");
                valid = false;
            }
            else
            {
                epCijena.Clear();
            }

            if (film == null)
            {
                epFilm.SetError(gbIzabraniFilm, "Izaberite film");
                valid = false;
            }
            else
            {
                epFilm.Clear();
            }

            return valid;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {

            if (validate())
            {
                if (izmjena)
                {
                    if (BioskopUtil.checkSalaAvailability(BioskopUtil.getSalaFromComboBox(cbSala), dtpDatum.Value.Date + dtpVrijeme.Value.TimeOfDay, this.projekcija.Id, film))
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
                        zauzetaSala();
                    }
                }
                else
                {
                    if (BioskopUtil.checkSalaAvailability(BioskopUtil.getSalaFromComboBox(cbSala), dtpDatum.Value.Date + dtpVrijeme.Value.TimeOfDay, -1, film))
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
                    else
                    {
                        zauzetaSala();
                    }
                }
            }
        }

        private void zauzetaSala()
        {
            MessageBox.Show("Sala je zauzeta u izabranom terminu!");
        }
    }
}
