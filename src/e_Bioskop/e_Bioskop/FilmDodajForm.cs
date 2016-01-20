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
            if (validate())
            {
                FilmDTO film = controlsToFIlm();
                BioskopUtil.getDAOFactory().getFilmDAO().insert(film);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
