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

        public ZaposleniForm()
        {
            InitializeComponent();
            hideProjekcijaProdajaKarteControlls();
            hideRezervisanjeControlls();
        }

        private void hideRezervisanjeControlls()
        {
            gbRezervacijaPodaciOFilmu.Hide();
            gbRezervisanjePodaciOProjekciji.Hide();
            gbRezervisanjePodaciORezervaciji.Hide();
            flwRezervacija.Controls.Clear();

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
        }


        private void btnIzborProjekcije_Click(object sender, EventArgs e)
        {
            ProjekcijaIzborForm pif = new ProjekcijaIzborForm();
            if (pif.ShowDialog() == DialogResult.OK)
            {
                if (izabranaProjekcija == null || izabranaProjekcija.Id != pif.IzabranaProjekcija.Id)
                {
                    izabranaProjekcija = pif.IzabranaProjekcija;
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
                foreach (Button b in listaIzabranihSjedista)
                {
                    KartaDTO karta = new KartaDTO();
                    karta.Projekcija = izabranaProjekcija;
                    karta.Status = BioskopUtil.getDAOFactory().getStatusKartaDAO().getByNaziv("Prodana");
                    karta.Zaposleni = BioskopUtil.getPrijavljeniZaposleni();
                    string str = b.Name.Replace("prodaja", "");
                    char[] del={'_'};
                    string[] s=str.Split(del,StringSplitOptions.RemoveEmptyEntries);
                    if (s.Length == 2)
                    {
                        karta.BrojSjedista = int.Parse(s[1]);
                        karta.BrojReda = int.Parse(s[0]);
                        if (BioskopUtil.isSjedisteAvalible(karta.BrojReda, karta.BrojSjedista, prodajaListaVecIzdatihKarata)==-1)
                        {
                            int id = (int)BioskopUtil.getDAOFactory().getKartaDAO().insert(karta);
                            karta.Id = id;                            
                        }
                    }

                }
                fillProjekcijaProdajaKarteControlls();
                
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
            ProjekcijaIzborForm pif = new ProjekcijaIzborForm();
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
            gbRezervacijaPodaciOFilmu.Show();
            gbRezervisanjePodaciOProjekciji.Show();
            gbRezervisanjePodaciORezervaciji.Show();
            sc1Rezervacija.Panel2.Show();
            lblRezervacijaNazivFilma.Text = izabranaProjekcija.Film.Naziv;
            lblRezervacijaOpisFilma.Text = izabranaProjekcija.Film.Opis;
            lblRezervacijaSalaProjekcije.Text = izabranaProjekcija.Sala.Naziv;
            lblRezervacijaZanr.Text = izabranaProjekcija.Film.Zanr.Naziv;
            prodajaListaVecIzdatihKarata=BioskopUtil.getDAOFactory().getKartaDAO().getByProjekcija(izabranaProjekcija);
            BioskopUtil.initSjedistDTOFlowLayout(flwRezervacija,izabranaProjekcija,prodajaIzborSjedistaClick,prodajaListaVecIzdatihKarata);
        }
    }
}
