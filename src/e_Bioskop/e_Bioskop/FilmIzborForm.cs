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
    public partial class FilmIzborForm : Form
    {
        List<FilmDTO> listaFilmova = null;
        private FilmDTO selektovaniFilm = null;

        public FilmDTO SelektovaniFilm
        {
            get { return selektovaniFilm; }
            set { selektovaniFilm = value; }
        }
        
        public FilmIzborForm()
        {
            InitializeComponent();
            listaFilmova = BioskopUtil.getDAOFactory().getFilmDAO().getAll();
            listaFilmova = listaFilmova.Where(x => x.Status.Id == 4 || x.Status.Id == 3).ToList();
            BioskopUtil.initFilmDTOListView(lvFilmovi, listaFilmova);
        }

        private void lvFilmovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(lvFilmovi.FocusedItem.Name);
            selektovaniFilm = listaFilmova.Where(x => x.Id == id).ToList().First();
        }

        private void btnIzaberi_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        



        
    }
}
