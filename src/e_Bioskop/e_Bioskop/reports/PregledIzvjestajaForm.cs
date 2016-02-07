using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using e_Bioskop.data.dto;

namespace e_Bioskop.reports
{
    public partial class PregledIzvjestajaForm : Form
    {
        private bool check = false;
        public PregledIzvjestajaForm(bool check)
        {
            InitializeComponent();
            this.check = check;
            
        }

        public PregledIzvjestajaForm(List<DistributerDTO> listaDistributera,bool check)
        {
            InitializeComponent();
            OnDistributers(listaDistributera);
            this.check = check;
        }


        public PregledIzvjestajaForm(List<DistributerDTO> listaDistributera, DateTime from, DateTime to,bool check)
        {
            InitializeComponent();
            OnDistributers(listaDistributera, from, to);
            this.check = check;
        }


        public PregledIzvjestajaForm(List<ZaposleniDTO> listaZaposlenih,DateTime from, DateTime to,bool check)
        {
            InitializeComponent();
            OnEmployees(listaZaposlenih, from, to);
            this.check = check;
        }

        public PregledIzvjestajaForm(List<FilmDTO> listaFilmova,bool check)
        {
            InitializeComponent();
            OnMovies(listaFilmova);
            this.check = check;
        }

        public void OnEmployees(List<ZaposleniDTO> listaZaposlenih, DateTime from, DateTime to)
        {
            OnEmployees(listaZaposlenih, from, to, true);
        }

        public void OnEmployees(List<ZaposleniDTO> listaZaposlenih)
        {
            OnEmployees(listaZaposlenih, DateTime.Now, DateTime.Now, false);
        }

        private void OnEmployees(List<ZaposleniDTO> listaZaposlenih, DateTime from, DateTime to,bool date)
        {
            PoZaposlenimaDataSet pzds = new PoZaposlenimaDataSet();
            
            foreach (ZaposleniDTO zaposleni in listaZaposlenih)
            {
                if (check)
                {
                    pzds.Zaposleni.Rows.Add(new object[] { zaposleni.Id, zaposleni.Ime, zaposleni.Prezime, zaposleni.DatumRodjenja.ToShortDateString() });
                }
                List<ProjekcijaDTO> listaProjekcija = listaProjekcija = BioskopUtil.getDAOFactory().getProjekcijaDAO().getAll();
                if (date)
                {
                    listaProjekcija = listaProjekcija.Where(x => x.Vrijeme.Date >= from.Date && x.Vrijeme.Date <= to.Date).ToList() ;
                }
                int k = 0;
                foreach (ProjekcijaDTO projekcija in listaProjekcija)
                {
                    List<KartaDTO> listaKarata = BioskopUtil.getDAOFactory().getKartaDAO().getByProjekcija(projekcija).Where(x => x.Zaposleni.Id == zaposleni.Id && x.Status.Naziv.Equals("Prodana")).ToList();
                    double prihod = listaKarata.Sum(x => x.Cijena);
                    int brojKarata = listaKarata.Count;
                    if (!check)
                    {
                        if (k == 0 && listaKarata.Count > 0)
                        {
                            k = 1;
                            pzds.Zaposleni.Rows.Add(new object[] { zaposleni.Id, zaposleni.Ime, zaposleni.Prezime, zaposleni.DatumRodjenja.ToShortDateString() });
                        }

                        if (brojKarata > 0)
                        {
                            pzds.Projekcija.Rows.Add(new object[] { projekcija.Id, projekcija.Film.Naziv, projekcija.Film.Zanr.Naziv, projekcija.Vrijeme.ToShortDateString()+" "+projekcija.Vrijeme.ToShortTimeString(), projekcija.Sala.Naziv, brojKarata, prihod, zaposleni.Id });
                        }
                    }
                    else
                    {
                        pzds.Projekcija.Rows.Add(new object[] { projekcija.Id, projekcija.Film.Naziv, projekcija.Film.Zanr.Naziv, projekcija.Vrijeme.ToShortDateString() + " " + projekcija.Vrijeme.ToShortTimeString(), projekcija.Sala.Naziv, brojKarata, prihod, zaposleni.Id });
                    }

                }
            }
            PoZaposlenimaIzvjestaj1 pzi = new PoZaposlenimaIzvjestaj1();
            pzi.SetDataSource(pzds);
            if (date)
            {
                pzi.SummaryInfo.ReportComments = "Od: " + from.ToShortDateString() + " do: " + to.ToShortDateString();
            }
            crystalReportViewer1.ReportSource = pzi;
        }


        public void OnDistributers(List<DistributerDTO> listaDistributera, DateTime from, DateTime to)
        {
            OnDistributers(listaDistributera, from, to, true);
        }

        public void OnDistributers(List<DistributerDTO> listaDistributera)
        {
            OnDistributers(listaDistributera, DateTime.Now, DateTime.Now, false);
        }

        private void OnDistributers(List<DistributerDTO> listaDistributera, DateTime from, DateTime to,bool date)
        {
            PoDistributerimaDataSet pds = new PoDistributerimaDataSet();
            foreach (DistributerDTO distributer in listaDistributera)
            {
                if (check)
                {
                    pds.Distributer.Rows.Add(new object[] { distributer.Id, distributer.Naziv, distributer.Adresa, distributer.Telefon, distributer.Email });
                }
                List<FilmDTO> listaFilmova = BioskopUtil.getDAOFactory().getFilmDAO().getAllByDistributer(distributer);
                int k = 0;
                foreach (FilmDTO film in listaFilmova)
                {
                    List<ProjekcijaDTO> listaProjekcija = BioskopUtil.getDAOFactory().getProjekcijaDAO().getByFilm(film);
                    if (date)
                    {
                        listaProjekcija = listaProjekcija.Where(x => x.Vrijeme.Date >= from.Date && x.Vrijeme.Date <= to.Date).ToList();
                    }
                    double sum = 0.0;
                    foreach (ProjekcijaDTO projekcija in listaProjekcija)
                    {
                       List<KartaDTO> listaKarata= BioskopUtil.getDAOFactory().getKartaDAO().getByProjekcija(projekcija);
                       listaKarata = listaKarata.Where(x => x.Status.Naziv.Equals("Prodana")).ToList();
                       sum += listaKarata.Sum(x => x.Cijena);
                    }
                    if (!check)
                    {
                        if (k == 0 && sum > 0)
                        {
                            k = 1;
                            pds.Distributer.Rows.Add(new object[] { distributer.Id, distributer.Naziv, distributer.Adresa, distributer.Telefon, distributer.Email });
                        }
                        if (sum > 0)
                        {
                            pds.Film.Rows.Add(new object[] { film.Id, film.Naziv, listaProjekcija.Count, sum, distributer.Id, film.Zanr.Naziv });
                        }
                    }
                    else
                    {
                        pds.Film.Rows.Add(new object[] { film.Id, film.Naziv, listaProjekcija.Count, sum, distributer.Id, film.Zanr.Naziv });
                    }
                }
            }
            PoDistributerimaIzvjestaj izvjestaj = new PoDistributerimaIzvjestaj();
            izvjestaj.SetDataSource(pds);
            if (date)
            {
                izvjestaj.SummaryInfo.ReportComments = "Od " + from.ToShortDateString() + " do " + to.ToShortDateString();
            }
            crystalReportViewer1.ReportSource = izvjestaj;
        }

        


        public void OnMovies(List<FilmDTO> listaFilmova)
        {
            OnMovies(listaFilmova, DateTime.Now, DateTime.Now, false);
        }

        public void OnMovies(List<FilmDTO> listaFilmova, DateTime from, DateTime to)
        {
            OnMovies(listaFilmova, from, to, true);
        }

        public void OnMovies(List<FilmDTO> listaFilmova,DateTime from, DateTime to,bool date)
        {
            PoFilmovimaDataSet pfds = new PoFilmovimaDataSet();
            foreach (FilmDTO film in listaFilmova)
            {
                if (check)
                {
                    pfds.Film.Rows.Add(new object[] { film.Id, film.Naziv, film.Opis, film.Zanr.Naziv, film.Status.Naziv });
                }
                List<ProjekcijaDTO> listaProjekcija = BioskopUtil.getDAOFactory().getProjekcijaDAO().getByFilm(film);
                if (date)
                {
                    listaProjekcija = listaProjekcija.Where(x => x.Vrijeme.Date >= from.Date && x.Vrijeme.Date <= to.Date).ToList();
                }
                int k = 0;
                foreach (ProjekcijaDTO projekcija in listaProjekcija)
                {
                    List<KartaDTO> listaKarata = BioskopUtil.getDAOFactory().getKartaDAO().getByProjekcija(projekcija).Where(x => x.Status.Naziv.Equals("Prodana")).ToList();
                    int brojKarata = listaKarata.Count;
                    double prihod = listaKarata.Sum(x => x.Cijena);
                    if (!check)
                    {
                        if (k == 0 && prihod > 0)
                        {
                            pfds.Film.Rows.Add(new object[] { film.Id, film.Naziv, film.Opis, film.Zanr.Naziv, film.Status.Naziv });
                        }
                        if (prihod > 0)
                        {
                            pfds.Projekcija.Rows.Add(new object[] { projekcija.Id, projekcija.Vrijeme.ToShortDateString(), projekcija.Vrijeme.ToShortTimeString(), brojKarata, prihod, film.Id });
                        }
                    }
                    else
                    {
                        pfds.Projekcija.Rows.Add(new object[] { projekcija.Id, projekcija.Vrijeme.ToShortDateString(), projekcija.Vrijeme.ToShortTimeString(), brojKarata, prihod, film.Id });
                    }
                }
            }
            PoFilmovimaIzvjestaj pfi = new PoFilmovimaIzvjestaj();
            pfi.SetDataSource(pfds);
            if (date)
            {
                pfi.SummaryInfo.ReportComments = "Od " + from.ToShortDateString() + " " + to.ToShortDateString();
            }
            crystalReportViewer1.ReportSource = pfi;
        }




    }
}
