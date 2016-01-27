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
        private FilmDTO film;

        public FilmDodajForm()
        {
            InitializeComponent();
            initComboBoxes();
        }

        public FilmDodajForm(FilmDTO film)
        {
            InitializeComponent();

            BioskopUtil.initDistributerComboBox(cbDistributer, film.Distributer.Id);
            BioskopUtil.initStatusFilmComboBox(cbStatus, film.Status.Id);
            BioskopUtil.initZanrComboBox(cbZanr, film.Zanr.Id);

            txbNaziv.Text = film.Naziv;
            txbOpis.Text = film.Opis;
            txbTrajanje.Value = film.Trajanje;

            this.film = film;
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

        private bool validate()
        {
            bool valid = true;

            if (string.IsNullOrEmpty(txbNaziv.Text))
            {
                epNaziv.SetError(txbNaziv, "Unesite naziv");
                valid = false;
            }
            else
            {
                epNaziv.Clear();
            }

            if (cbZanr.SelectedIndex < 0)
            {
                epZanr.SetError(cbZanr, "Izaberite zanr");
                valid = false;
            }
            else
            {
                epZanr.Clear();
            }

            if (cbStatus.SelectedIndex < 0)
            {
                epStatus.SetError(cbStatus, "Izaberite status");
                valid = false;
            }
            else
            {
                epStatus.Clear();
            }

            if (cbDistributer.SelectedIndex < 0)
            {
                epDistributer.SetError(cbDistributer, "Izaberite distributera");
                valid = false;
            }
            else
            {
                epDistributer.Clear();
            }

            if (string.IsNullOrEmpty(txbOpis.Text))
            {
                epOpis.SetError(txbOpis, "Unesite opis");
                valid = false;
            }
            else
            {
                epOpis.Clear();
            }

            return valid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (film == null)
            {
                if (validate())
                {
                    FilmDTO film1 = controlsToFIlm();
                    BioskopUtil.getDAOFactory().getFilmDAO().insert(film1);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                updateFromControls();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void updateFromControls()
        {
            if (validate())
            {
                film.Naziv = txbNaziv.Text;
                film.Opis = txbOpis.Text;
                film.Trajanje = (int)txbTrajanje.Value;
                film.Zanr = BioskopUtil.getZanrDTOFromComboBox(cbZanr);
                film.Status = BioskopUtil.getStatusFilmDTOfromComboBox(cbStatus);
                film.Distributer = BioskopUtil.getDistributerDTOFromComboBox(cbDistributer);
                BioskopUtil.getDAOFactory().getFilmDAO().update(film);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
