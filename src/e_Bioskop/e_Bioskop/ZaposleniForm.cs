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
        private ProjekcijaDTO izabranaProjekcijaZaProdaju;
        private List<SjedisteDTO> izabranoSjedisteZaProdaju;
        private Color nijeIzabrano = System.Drawing.Color.Transparent;
        private Color izabrano = System.Drawing.Color.Aqua;
        private List<Button> listaIzabranihSjedista = new List<Button>();
        public ZaposleniForm()
        {
            InitializeComponent();
            hideProjekcijaProdajaKarteControlls();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {

        }

        private void btnDodajDistributera_Click(object sender, EventArgs e)
        {

        }

        private void btnDodajFilm_Click(object sender, EventArgs e)
        {

        }

        private void btnIzborProjekcije_Click(object sender, EventArgs e)
        {
            ProjekcijaIzborForm pif = new ProjekcijaIzborForm();
            if (pif.ShowDialog() == DialogResult.OK)
            {
                if (izabranaProjekcijaZaProdaju == null || izabranaProjekcijaZaProdaju.Id != pif.IzabranaProjekcija.Id)
                {
                    izabranaProjekcijaZaProdaju = pif.IzabranaProjekcija;
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
            lblProdajaKarteNazivFilma.Text = izabranaProjekcijaZaProdaju.Film.Naziv;
            lblProdajaKarteOpis.Text = izabranaProjekcijaZaProdaju.Film.Opis;
            lblProdajaKarteZanr.Text = izabranaProjekcijaZaProdaju.Film.Zanr.Naziv;
            lblProdajaSalaProjekcije.Text = izabranaProjekcijaZaProdaju.Sala.Naziv;
            lblProdajaVrijemeProjekcije.Text=izabranaProjekcijaZaProdaju.Vrijeme.ToShortDateString()+" " +izabranaProjekcijaZaProdaju.Vrijeme.TimeOfDay.ToString();
            List<SjedisteDTO> lista = BioskopUtil.getDAOFactory().getSjedisteDAO().getBySala(izabranaProjekcijaZaProdaju.Sala);
            listaIzabranihSjedista.Clear();
            BioskopUtil.initSjedistDTOFlowLayout(flowLayoutPanel1, lista, prodajaIzborSjedistaClick);
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

        private void hideProjekcijaProdajaKarteControlls()
        {
            gbProdajaPodaciOFilmu.Hide();
            gbProdajaPodaciOProjekciji.Hide();
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
            List<SjedisteDTO> lista=BioskopUtil.getDAOFactory().getSjedisteDAO().getBySala(izabranaProjekcijaZaProdaju.Sala);
            int brojSjedistaURedu = lista.Where(x => x.Red == 0).Count();
            int brojRedova = lista.Where(x => x.Broj == 0).Count();
            if (brojSjedistaURedu > 0 && brojRedova > 0)
            {
                int height = (flowLayoutPanel1.Height / (brojRedova) - flowLayoutPanel1.Margin.Vertical);
                int width = (flowLayoutPanel1.Width / (brojSjedistaURedu)) - flowLayoutPanel1.Margin.Horizontal;
                for (int i = 0; i < count; i++)
                {
                    Control control = flw.Controls[i];
                    control.Width = width;
                    control.Height = height;
                }
            }
        }
    }
}
