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
    public partial class ZaposleniForm : Form
    {
        private ProjekcijaDTO izabranaProjekcija;
        private Color nijeIzabrano = System.Drawing.Color.Transparent;
        private Color izabrano = System.Drawing.Color.Aqua;
        private List<Button> listaIzabranihSjedista = new List<Button>();
        private List<KartaDTO> prodajaListaVecIzdatihKarata = null;
        private RezervacijaDTO izabranaRezervacija;
        public ZaposleniForm()
        {
            InitializeComponent();
            hideProjekcijaProdajaKarteControlls();
            hideRezervisanjeControlls();
            ZaposleniDTO zaposleni = BioskopUtil.getPrijavljeniZaposleni();
            lblImePrezime.Text = zaposleni.Ime + " " + zaposleni.Prezime;
            comboBox1.SelectedIndex = 0;
        }

        private void hideRezervisanjeControlls()
        {
            gbRezervacijaPodaciOFilmu.Hide();
            gbRezervisanjePodaciOProjekciji.Hide();
            gbRezervisanjePodaciORezervaciji.Hide();
            flwRezervacija.Controls.Clear();
            btnRezervisi.Visible = false;
        }

        private void hideProjekcijaProdajaKarteControlls()
        {
            gbProdajaPodaciOFilmu.Hide();
            gbProdajaPodaciOProjekciji.Hide();
            izabranaProjekcija = null;
            listaIzabranihSjedista.Clear();
            prodajaListaVecIzdatihKarata = null;
            flwProdaja.Controls.Clear();
            sc1Prodaja.Panel2.Hide();
            gbProdajaPodaciORezervaciji.Hide();
        }


        private void btnIzborProjekcije_Click(object sender, EventArgs e)
        {
            ProjekcijaIzborForm pif = new ProjekcijaIzborForm();
            if (pif.ShowDialog() == DialogResult.OK)
            {
                if (izabranaProjekcija == null || izabranaProjekcija.Id != pif.IzabranaProjekcija.Id)
                {
                    izabranaProjekcija = pif.IzabranaProjekcija;
                    lblCijena.Text = izabranaProjekcija.Cijena.ToString() + " KM";
                    showProjekcijaProdajaKarteControlls();
                }
            }
            
        }

        private void btnOdjava_Click_1(object sender, EventArgs e)
        {
            BioskopUtil.odjavaZaposleni();
            this.Close();
            PrijavaForm prijava = new PrijavaForm();
            prijava.Show();
        }

        private void fillProjekcijaProdajaKarteControlls()
        {
            sc1Prodaja.Panel2.Show();
            lblProdajaKarteNazivFilma.Text = izabranaProjekcija.Film.Naziv;
            lblProdajaKarteOpis.Text = izabranaProjekcija.Film.Opis;
            lblProdajaKarteZanr.Text = izabranaProjekcija.Film.Zanr.Naziv;
            lblProdajaSalaProjekcije.Text = izabranaProjekcija.Sala.Naziv;
            lblProdajaVrijemeProjekcije.Text=izabranaProjekcija.Vrijeme.ToShortDateString()+" " +izabranaProjekcija.Vrijeme.TimeOfDay.ToString();
            
            listaIzabranihSjedista.Clear();
            prodajaListaVecIzdatihKarata = BioskopUtil.getDAOFactory().getKartaDAO().getByProjekcija(izabranaProjekcija);
            BioskopUtil.initSjedistDTOFlowLayout(flwProdaja, izabranaProjekcija, prodajaIzborSjedistaClick,prodajaListaVecIzdatihKarata);
        }


        private void prodajaIzborSjedistaClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (listaIzabranihSjedista.Where(x => x.Name.Equals(b.Name)).Count()>0)
            {
                    listaIzabranihSjedista.Remove(b);
                    b.BackColor = nijeIzabrano;
            }
            else
            {
                b.BackColor = izabrano;
                listaIzabranihSjedista.Add(b);
            }     
        }


        private void showProjekcijaProdajaKarteControlls()
        {
            fillProjekcijaProdajaKarteControlls();
            gbProdajaPodaciOProjekciji.Show();
            gbProdajaPodaciOFilmu.Show();
            gbProdajaPodaciORezervaciji.Show();
        }

        private void flowLayoutPanel1_Resize(object sender, EventArgs e)
        {
            FlowLayoutPanel flw = (FlowLayoutPanel)sender;
            int count=flw.Controls.Count;
            int brojSjedistaURedu = izabranaProjekcija.Sala.BrojSjedistaURedu;
            int brojRedova = izabranaProjekcija.Sala.BrojRedova;
            if (brojSjedistaURedu > 0 && brojRedova > 0)
            {
                int height = (flwProdaja.Height / (brojRedova) - flwProdaja.Margin.Vertical);
                int width = (flwProdaja.Width / (brojSjedistaURedu)) - flwProdaja.Margin.Horizontal;
                for (int i = 0; i < count; i++)
                {
                    Control control = flw.Controls[i];
                    control.Width = width;
                    control.Height = height;
                }
            }
        }

        private void btnProdajaKarata_Click(object sender, EventArgs e)
        {
            if (listaIzabranihSjedista != null && listaIzabranihSjedista.Count() > 0)
            {
                StatusKartaDTO prodana= BioskopUtil.getDAOFactory().getStatusKartaDAO().getByNaziv("Prodana");
                StatusKartaDTO rezervisana=BioskopUtil.getDAOFactory().getStatusKartaDAO().getByNaziv("Rezervisana");
                List<KartaDTO> listaZaRezervaciju=new List<KartaDTO>();
                if(izabranaRezervacija!=null)
                {
                listaZaRezervaciju=BioskopUtil.getDAOFactory().getKartaDAO().getByProjekcijaAndRezervacija(izabranaProjekcija,izabranaRezervacija);
                }
                foreach (Button b in listaIzabranihSjedista)
                {
                    KartaDTO karta = new KartaDTO();
                    karta.Projekcija = izabranaProjekcija;
                    karta.Status = prodana;
                    karta.Zaposleni = BioskopUtil.getPrijavljeniZaposleni();
                    karta.Cijena = izabranaProjekcija.Cijena - izabranaProjekcija.Cijena * (comboBox1.SelectedIndex / 10.0);
                    string str = b.Name.Replace("prodaja", "");
                    char[] del={'_'};
                    string[] s=str.Split(del,StringSplitOptions.RemoveEmptyEntries);
                    if (s.Length == 2)
                    {
                        karta.BrojSjedista = int.Parse(s[1]);
                        karta.BrojReda = int.Parse(s[0]);
                        if (BioskopUtil.isSjedisteAvalible(karta.BrojReda, karta.BrojSjedista, prodajaListaVecIzdatihKarata).Equals("Slobodna"))
                        {
                            int id = (int)BioskopUtil.getDAOFactory().getKartaDAO().insert(karta);
                            karta.Id = id;                            
                        }
                    }
                    if (s.Length == 3)
                    {
                        karta = listaZaRezervaciju.Where(x => x.Id == int.Parse(s[0])).First();
                        karta.Status = prodana;
                        karta.Zaposleni = BioskopUtil.getPrijavljeniZaposleni();
                        BioskopUtil.getDAOFactory().getKartaDAO().update(karta);
                    }
                    gbProdajaPodaciORezervaciji.Hide();
                }
                fillProjekcijaProdajaKarteControlls();
                if (izabranaRezervacija != null)
                {
                    izabranaRezervacija.Aktivna = 0;
                    BioskopUtil.getDAOFactory().getRezervacijaDAO().update(izabranaRezervacija);
                    izabranaRezervacija = null;
                }
            }
            
        }

        private void btnPregledRasporeda_Click(object sender, EventArgs e)
        {
            PregledRasporedaForm prf = new PregledRasporedaForm();
            prf.ShowDialog();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            hideProjekcijaProdajaKarteControlls();
            hideRezervisanjeControlls();
        }

        private void btnRezervisanjeIzborProjekcije_Click(object sender, EventArgs e)
        {
            ProjekcijaIzborForm pif = new ProjekcijaIzborForm(1);
            if (pif.ShowDialog() == DialogResult.OK)
            {
                if (izabranaProjekcija == null || izabranaProjekcija.Id != pif.IzabranaProjekcija.Id)
                {
                    izabranaProjekcija = pif.IzabranaProjekcija;
                    fillRezervisanjeControls();
                }
            }
        }

        private void fillRezervisanjeControls()
        {
            btnRezervisi.Visible = true;
            gbRezervacijaPodaciOFilmu.Show();
            gbRezervisanjePodaciOProjekciji.Show();
            gbRezervisanjePodaciORezervaciji.Show();
            sc1Rezervacija.Panel2.Show();
            lblRezervacijaVrijemeProjekcije.Text = izabranaProjekcija.Vrijeme.ToShortDateString() + " " + izabranaProjekcija.Vrijeme.TimeOfDay.ToString();
            lblRezervacijaNazivFilma.Text = izabranaProjekcija.Film.Naziv;
            lblRezervacijaOpisFilma.Text = izabranaProjekcija.Film.Opis;
            lblRezervacijaSalaProjekcije.Text = izabranaProjekcija.Sala.Naziv;
            lblRezervacijaZanr.Text = izabranaProjekcija.Film.Zanr.Naziv;
            prodajaListaVecIzdatihKarata=BioskopUtil.getDAOFactory().getKartaDAO().getByProjekcija(izabranaProjekcija);
            BioskopUtil.initSjedistDTOFlowLayout(flwRezervacija,izabranaProjekcija,prodajaIzborSjedistaClick,prodajaListaVecIzdatihKarata);
        }

        private void btnRezervisi_Click(object sender, EventArgs e)
        {
            if (listaIzabranihSjedista != null && listaIzabranihSjedista.Count() > 0)
            {
                tbxRezervacijaOpisRezervacije.Text = "";
                 RezervacijaDTO rezervacija = new RezervacijaDTO();
                 rezervacija.Zaposleni = BioskopUtil.getPrijavljeniZaposleni();
                 rezervacija.Opis = tbxRezervacijaOpisRezervacije.Text;
                 rezervacija.VrijemeRezervacije = DateTime.Now;
                 rezervacija.Aktivna = 1;
                int id=(int) BioskopUtil.getDAOFactory().getRezervacijaDAO().insert(rezervacija);
                rezervacija.Id = id;
                StatusKartaDTO rezervisanaStatus = BioskopUtil.getDAOFactory().getStatusKartaDAO().getByNaziv("Rezervisana");
                foreach (Button b in listaIzabranihSjedista)
                {
                    KartaDTO karta = new KartaDTO();
                    karta.Projekcija = izabranaProjekcija;
                    karta.Status = rezervisanaStatus;
                    karta.Zaposleni = BioskopUtil.getPrijavljeniZaposleni();
                    karta.Rezervacija = rezervacija;
                    string str = b.Name.Replace("prodaja", "");
                    char[] del = { '_' };
                    string[] s = str.Split(del, StringSplitOptions.RemoveEmptyEntries);
                    if (s.Length == 2)
                    {
                        karta.BrojSjedista = int.Parse(s[1]);
                        karta.BrojReda = int.Parse(s[0]);
                        
                        if (BioskopUtil.isSjedisteAvalible(karta.BrojReda, karta.BrojSjedista, prodajaListaVecIzdatihKarata).Equals("Slobodna"))
                        {
                            int idk = (int)BioskopUtil.getDAOFactory().getKartaDAO().insert(karta);
                            karta.Id = idk;
                        }
                    }

                }
                fillRezervisanjeControls();

            }
        }

        private void btnProdajaIzaberiRezervaciju_Click(object sender, EventArgs e)
        {
            RezervacijePregledForm rpf = new RezervacijePregledForm(izabranaProjekcija);
            if (rpf.ShowDialog() == DialogResult.OK)
            {
                izabranaRezervacija = rpf.IzabranaRezervacija;
                
                List<KartaDTO> listaKarataZaRezervaciju = BioskopUtil.getDAOFactory().getKartaDAO().getByProjekcijaAndRezervacija(izabranaProjekcija,izabranaRezervacija);
                if (izabranaProjekcija == null)
                {
                    izabranaProjekcija = listaKarataZaRezervaciju[0].Projekcija;
                    showProjekcijaProdajaKarteControlls();
                    lblOpis.Text = izabranaRezervacija.Opis;
                }
                BioskopUtil.initSjedistDTOFlowLayout(flwProdaja, izabranaProjekcija, prodajaIzborSjedistaClick, prodajaListaVecIzdatihKarata);
                listaIzabranihSjedista.Clear();
                foreach(KartaDTO karta in listaKarataZaRezervaciju)
                {
                    Button b = (Button)flwProdaja.Controls["prodaja" + karta.BrojReda + "_" + karta.BrojSjedista];
                    b.Click += prodajaIzborSjedistaClick;
                    b.Name = karta.Id+"_"+b.Name;
                    b.BackColor = System.Drawing.Color.Yellow;
                    listaIzabranihSjedista.Add(b);
                }
            }
        }

        private void btnPonistavanjeKarte_Click(object sender, EventArgs e)
        {
            PonistavanjeKarteForm pkf = new PonistavanjeKarteForm();
            pkf.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (izabranaProjekcija != null)
              lblCijena.Text = (izabranaProjekcija.Cijena - izabranaProjekcija.Cijena * (comboBox1.SelectedIndex / 10.0)).ToString() + " KM";
        }

        private void ZaposleniForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (BioskopUtil.getPrijavljeniZaposleni() != null)
            {
                Application.Exit();
            }
        }

        private void btnPonistiRezervaciju_Click(object sender, EventArgs e)
        {
            RezervacijePregledForm rpf = new RezervacijePregledForm();

            if (rpf.ShowDialog() == DialogResult.OK)
            {
                izabranaRezervacija = rpf.IzabranaRezervacija;
                List<KartaDTO> listaKarataZaRezervaciju = BioskopUtil.getDAOFactory().getKartaDAO().getByProjekcijaAndRezervacija(izabranaProjekcija, izabranaRezervacija);
                izabranaRezervacija.Aktivna = 0;
                BioskopUtil.getDAOFactory().getRezervacijaDAO().update(izabranaRezervacija);

                foreach(KartaDTO karta in listaKarataZaRezervaciju)
                {
                    karta.Status.Id = 3;
                    BioskopUtil.getDAOFactory().getKartaDAO().update(karta);
                }
            }
        }
    }
}
