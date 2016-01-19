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
    public partial class UpravnikForm : Form
    {
        List<FilmDTO> listaFilmovaZaNarucivanje = null;
        FilmDTO trenutniFilm=null;

        public UpravnikForm()
        {
            InitializeComponent();
            popuniListuFilmovaZaNarucivanje();
            hideTrenutniFilmZaNarucivanjeDetails();
        }

        private void popuniListuFilmovaZaNarucivanje()
        {
            StatusFilmDTO status=BioskopUtil.getDAOFactory().getStatusFilmDAO().getById(1);
            listaFilmovaZaNarucivanje = BioskopUtil.getDAOFactory().getFilmDAO().getAllByStatusFilm(status);
            BioskopUtil.initFilmDTOListView(lvFilmoviNarucivanje, listaFilmovaZaNarucivanje);
        }

        

        private void setTrenutrniFilmZaNarucivanjeDetails()
        {
            splitContainer1.Panel2.Show();
           lblNarucivanjeNazivFilma.Text= trenutniFilm.Naziv;
           lblNarucivanjeOpisFilma.Text = trenutniFilm.Opis;
           lblNarucivanjeZanrFilma.Text = trenutniFilm.Zanr.Naziv;
           lblNarucivanjeNazivDistributera.Text = trenutniFilm.Distributer.Naziv;
           lblNarucivanjeTelefonDistributera.Text = trenutniFilm.Distributer.Telefon;
           lblNarucivanjeAdresaDistributera.Text = trenutniFilm.Distributer.Adresa;
        }


        private void hideTrenutniFilmZaNarucivanjeDetails()
        {
            splitContainer1.Panel2.Hide();
        }

        private void lvFilmoviNarucivanje_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id=int.Parse(lvFilmoviNarucivanje.FocusedItem.Name);
            trenutniFilm=listaFilmovaZaNarucivanje.Where(x => x.Id == id).ToList().First();
           // trenutniFilm =BioskopUtil.getDAOFactory().getFilmDAO().getById(id);
            if(trenutniFilm!=null)
            setTrenutrniFilmZaNarucivanjeDetails();
        }

        private void btnNarucivanje_Click(object sender, EventArgs e)
        {
            trenutniFilm.Status = BioskopUtil.getDAOFactory().getStatusFilmDAO().getById(2);
            BioskopUtil.getDAOFactory().getFilmDAO().update(trenutniFilm);
            hideTrenutniFilmZaNarucivanjeDetails();
            popuniListuFilmovaZaNarucivanje();
        }

        private void promjeniListuFilmovaPoNazivu()
        {
            StringComparison comparison = StringComparison.InvariantCultureIgnoreCase;
            
            List<FilmDTO> lista=listaFilmovaZaNarucivanje.Where(x => x.Naziv.StartsWith(txbSearchNarucivanje.Text,comparison)).ToList();
            BioskopUtil.initFilmDTOListView(lvFilmoviNarucivanje, lista);
        }

        private void txbSearchNarucivanje_TextChanged(object sender, EventArgs e)
        {
            promjeniListuFilmovaPoNazivu();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            BioskopUtil.odjavaZaposleni();
            this.DialogResult = DialogResult.OK;
        }




    }
}
