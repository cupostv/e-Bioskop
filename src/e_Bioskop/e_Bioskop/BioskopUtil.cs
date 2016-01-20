using e_Bioskop.data.dao;
using e_Bioskop.data.dao.mysql;
using e_Bioskop.data.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace e_Bioskop
{
    public class BioskopUtil
    {
        private static DAOFactory daoFactory = null;

        private static ZaposleniDTO prijavljeniZaposleni = null;

        public static DAOFactory getDAOFactory()
        {
            if (daoFactory == null)
            {
                daoFactory = new MySqlDAOFactory();
            }
            return daoFactory;
        }

        public static ZaposleniDTO getPrijavljeniZaposleni()
        {
            return prijavljeniZaposleni;
        }

        public static void prijavaZaposleni(ZaposleniDTO zaposleni)
        {
            prijavljeniZaposleni = zaposleni;
        }

        public static void odjavaZaposleni()
        {
            prijavljeniZaposleni = null;
        }

        public static string sha256(string password)
        {
            System.Security.Cryptography.SHA256Managed crypt = new System.Security.Cryptography.SHA256Managed();
            System.Text.StringBuilder hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(password), 0, Encoding.UTF8.GetByteCount(password));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }

        public static void initRadnoMjestoComboBox(ComboBox comboBox, int id)
        {
            List<RadnoMjestoDTO> lista = getDAOFactory().getRadnoMjestoDAO().getAll();
            foreach(RadnoMjestoDTO radnoMjesto in lista)
            {
                comboBox.Items.Add(radnoMjesto.Naziv);
                if (radnoMjesto.Id == id)
                {
                    comboBox.SelectedIndex = comboBox.Items.Count - 1;
                }
            }
        }

        public static RadnoMjestoDTO getRadnoMjestoFromComboBox(ComboBox comboBox)
        {
            string naziv= comboBox.Items[comboBox.SelectedIndex].ToString();
            return getDAOFactory().getRadnoMjestoDAO().getByNaziv(naziv);
        }

        public static void initDistributerComboBox(ComboBox comboBox,int id)
        {
            List<DistributerDTO> lista = getDAOFactory().getDistributerDAO().getAll();
            foreach (DistributerDTO distributer in lista)
            {
                comboBox.Items.Add(distributer.Naziv);
                if (distributer.Id == id)
                {
                    comboBox.SelectedIndex = comboBox.Items.Count - 1;
                }
            }
        }

        public static DistributerDTO getDistributerDTOFromComboBox(ComboBox comboBox)
        {
            string naziv = comboBox.Items[comboBox.SelectedIndex].ToString();
            return getDAOFactory().getDistributerDAO().getByNaziv(naziv);

        }

        public static void initStatusFilmComboBox(ComboBox comboBox, int id)
        {
            List<StatusFilmDTO> list = getDAOFactory().getStatusFilmDAO().getAll();
            foreach (StatusFilmDTO status in list)
            {
                comboBox.Items.Add(status.Naziv);
                if (status.Id == id)
                {
                    comboBox.SelectedIndex = comboBox.Items.Count - 1;
                }
            }
        }
        public static StatusFilmDTO getStatusFilmDTOfromComboBox(ComboBox comboBox)
        {
            string naziv = comboBox.Items[comboBox.SelectedIndex].ToString();
            return getDAOFactory().getStatusFilmDAO().getByNaziv(naziv);
        }

        public static void initZanrComboBox(ComboBox comboBox, int id)
        {
            List<ZanrDTO> lista = getDAOFactory().getZanrDAO().getAll();
            foreach (ZanrDTO zanr in lista)
            {
                comboBox.Items.Add(zanr.Naziv);
                if (zanr.Id == id)
                {
                    comboBox.SelectedIndex = comboBox.Items.Count - 1;
                }
            }
        }

        public static ZanrDTO getZanrDTOFromComboBox(ComboBox comboBox)
        {
            string naziv = comboBox.Items[comboBox.SelectedIndex].ToString();
            return getDAOFactory().getZanrDAO().getByNaziv(naziv);
        }

        public static void initFilmDTOListView(ListView lvFilm, List<FilmDTO> listaFilmova)
        {
            lvFilm.Items.Clear();
            foreach (FilmDTO film in listaFilmova)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Name = film.Id + "";
                lvi.Text = film.Naziv;
                lvi.SubItems.Add(film.Zanr.Naziv);
                lvi.SubItems.Add(film.Trajanje + "");
                lvi.SubItems.Add(film.Opis);
                lvFilm.Items.Add(lvi);
            }
        }



    }
}
