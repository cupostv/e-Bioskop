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
        public ProjekcijaDodajForm()
        {
            InitializeComponent();
            gbIzabraniFilm.Hide();
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
    }
}
