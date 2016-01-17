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
    public partial class FilmDodajForm : Form
    {
        public FilmDodajForm()
        {
            InitializeComponent();
            initComboBoxes();
        }

        private void initComboBoxes()
        {
            BioskopUtil.initDistributerComboBox(cbDistributer, -1);
            BioskopUtil.initStatusFilmComboBox(cbStatus, -1);
            BioskopUtil.initZanrComboBox(cbZanr, -1);
        }

        private FilmDTO controlsToFIlm()
        {
            FilmDTO film = new FilmDTO();
            film.Naziv = txbNaziv.Text;
            film.Opis = txbOpis.Text;
            film.Status = BioskopUtil.getStatusFilmDTOfromComboBox(cbStatus);
            film.Zanr = BioskopUtil.getZanrDTOFromComboBox(cbZanr);
            film.Distributer = BioskopUtil.getDistributerDTOFromComboBox(cbDistributer);
            film.Trajanje = (int)txbTrajanje.Value;
            return film;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FilmDTO film = controlsToFIlm();
            BioskopUtil.getDAOFactory().getFilmDAO().insert(film);
        }
    }
}
