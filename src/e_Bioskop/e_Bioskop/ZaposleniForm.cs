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
        private SjedisteDTO izabranoSjedisteZaProdaju;
        private Button dugmeIzabranogSjedista = null;
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
                izabranaProjekcijaZaProdaju = pif.IzabranaProjekcija;
                showProjekcijaProdajaKarteControlls();
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
            ss();
        }

        private void ss()
        {
            flowLayoutPanel1.Controls.Clear();
            List<SjedisteDTO> lista = BioskopUtil.getDAOFactory().getSjedisteDAO().getBySala(izabranaProjekcijaZaProdaju.Sala);
            int brojSjedistaURedu = lista.Where(x => x.Red == 1).Count();
            int brojRedova=lista.Where(x=> x.Broj==1).Count();
            if (brojSjedistaURedu > 0 && brojRedova > 0)
            {
                int height = (flowLayoutPanel1.Height / (brojRedova+1)) - 1;
                int width = (flowLayoutPanel1.Width / (brojSjedistaURedu+1)) - 1;
                foreach (SjedisteDTO sjediste in lista)
                {
                    Button b = new Button();
                    b.Width = width;
                    b.BackColor = System.Drawing.Color.White;
                    b.Height = height;
                    b.FlatStyle = FlatStyle.Flat;
                    b.Click += new EventHandler(prodajaIzborSjedistaClick);
                    b.Name = "prodaja" + sjediste.Id;
                    flowLayoutPanel1.Controls.Add(b);
                }
            }
        }

        private void prodajaIzborSjedistaClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (dugmeIzabranogSjedista != null)
                dugmeIzabranogSjedista.BackColor = System.Drawing.Color.White;
            int idSjedista = int.Parse(b.Name.Replace("prodaja", "").Trim());
            b.BackColor = System.Drawing.Color.Blue;
            dugmeIzabranogSjedista = b;            
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
    }
}
