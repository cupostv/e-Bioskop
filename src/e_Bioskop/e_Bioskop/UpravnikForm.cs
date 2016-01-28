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
        List<ProjekcijaDTO> listaProjekcija = null;
        ProjekcijaDTO trenutnaProjekcija;
        private PregledRasporedaForm prf=null;
        public UpravnikForm()
        {
            InitializeComponent();
            popuniListuFilmovaZaNarucivanje();
            hideTrenutniFilmZaNarucivanjeDetails();
            popuniListuProjekcija();
        }

        private void popuniListuFilmovaZaNarucivanje()
        {
            StatusFilmDTO status=BioskopUtil.getDAOFactory().getStatusFilmDAO().getById(1);
            listaFilmovaZaNarucivanje = BioskopUtil.getDAOFactory().getFilmDAO().getAllByStatusFilm(status);
            BioskopUtil.initFilmDTOListView(lvFilmoviNarucivanje, listaFilmovaZaNarucivanje);
        }

        private void popuniListuProjekcija()
        {
            listaProjekcija = BioskopUtil.getDAOFactory().getProjekcijaDAO().getAll();
            BioskopUtil.initProjekcijaDTOListView(lvProjekcije, listaProjekcija);
        }

        

        private void setTrenutrniFilmZaNarucivanjeDetails()
        {
            splitContainer1.Panel2.Show();
           lblNarucivanjeNazivFilma.Text= trenutniFilm.Naziv;
           lblNarucivanjeOpisFilma.Text = trenutniFilm.Opis;
           lblNarucivanjeZanrFilma.Text = trenutniFilm.Zanr.Naziv;
           lblNarucivanjeTrajanjeFilma.Text = trenutniFilm.Trajanje + " minuta";
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

        private void btnDodajProjekciju_Click(object sender, EventArgs e)
        {
            ProjekcijaDodajForm pdf = new ProjekcijaDodajForm();
            if (pdf.ShowDialog() == DialogResult.OK)
            {
                popuniListuProjekcija();
            }
        }

        private void lvProjekcije_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(lvProjekcije.FocusedItem.Name);
            trenutnaProjekcija = listaProjekcija.Where(x => x.Id == id).First();
            setTrenutnaProjekcijaDetails();
        }

        private void setTrenutnaProjekcijaDetails()
        {
            lblProjekcijeNazivFilma.Text = trenutnaProjekcija.Film.Naziv;
            lblProjekcijeOpisFilma.Text = trenutnaProjekcija.Film.Opis;
            lblProjekcijeZanrFilma.Text = trenutnaProjekcija.Film.Zanr.Naziv;
            lblProjekcijeNazivDistributera.Text = trenutnaProjekcija.Film.Distributer.Naziv;
            lblProjekcijeTelefonDistributera.Text = trenutnaProjekcija.Film.Distributer.Telefon;
            lblProjekcijeVrijeme.Text = trenutnaProjekcija.Vrijeme.ToShortDateString() + " u " + trenutnaProjekcija.Vrijeme.ToShortTimeString() + " časova";
            lblProjekcijeSala.Text = "Sala: " + trenutnaProjekcija.Sala.Naziv;
            lblProjekcijeAdresaDistributera.Text = trenutnaProjekcija.Film.Distributer.Adresa;
        }

        private void btnIzmjeniProjekciju_Click(object sender, EventArgs e)
        {
            ProjekcijaDodajForm pdf = new ProjekcijaDodajForm(trenutnaProjekcija);
            if (pdf.ShowDialog() == DialogResult.OK)
            {
                popuniListuProjekcija();
                trenutnaProjekcija = listaProjekcija.Where(x => x.Id == trenutnaProjekcija.Id).First();
                setTrenutnaProjekcijaDetails();
            }
        }

        private void tbxProjekcijaSearch_TextChanged(object sender, EventArgs e)
        {
            StringComparison comparison = StringComparison.InvariantCultureIgnoreCase;
            List<ProjekcijaDTO> lista = listaProjekcija.Where(x => x.Film.Naziv.StartsWith(tbxProjekcijaSearch.Text, comparison)).ToList();
            BioskopUtil.initProjekcijaDTOListView(lvProjekcije, lista);
        }

        private void btnPregledRasporeda_Click(object sender, EventArgs e)
        {
            if(prf==null)
            prf = new PregledRasporedaForm();
            prf.Show();
        }



    }
}
