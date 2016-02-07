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
    public partial class RezervacijePregledForm : Form
    {
        private ProjekcijaDTO projekcija;
        private RezervacijaDTO izabranaRezervacija;
        private List<RezervacijaDTO> lista=new List<RezervacijaDTO>();
        public RezervacijaDTO IzabranaRezervacija
        {
            get { return izabranaRezervacija; }
            set { izabranaRezervacija = value; }
        }
        

        public RezervacijePregledForm(ProjekcijaDTO projekcija)
        {
            InitializeComponent();
            this.projekcija = projekcija;
            initRezervacijeGridView();
        }

        public RezervacijePregledForm()
        {
            InitializeComponent();
            initPonistiRezervacijuGridView();
        }

        private void initRezervacijeGridView()
        {
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;

            dataGridView1.Dock = DockStyle.Fill;
            label1.Hide();
            tbxOpis.Hide();

            lista.Clear();
            if (projekcija != null)
            {
                lista = BioskopUtil.getDAOFactory().getRezervacijaDAO().getAllByProjekcija(projekcija);
            }
            else
            {
                lista = BioskopUtil.getDAOFactory().getRezervacijaDAO().getAllActiveRezervacija();
            }
            dataGridView1.Rows.Clear();
            foreach (RezervacijaDTO rez in lista)
            {
                dataGridView1.Rows.Add(rez.Id, rez.VrijemeRezervacije.ToShortDateString(), rez.VrijemeRezervacije.TimeOfDay, rez.Opis, "Izaberi");
            }
        }

        private void initPonistiRezervacijuGridView()
        {
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            label1.Show();
            tbxOpis.Show();
            dataGridView1.Dock = DockStyle.None;

            lista.Clear();

            ponistiIstekleRezervacije();
            lista = BioskopUtil.getDAOFactory().getRezervacijaDAO().getAllActiveRezervacija();

            foreach (RezervacijaDTO rez in lista)
            {
                dataGridView1.Rows.Add(rez.Id, rez.VrijemeRezervacije.ToShortDateString(), rez.VrijemeRezervacije.TimeOfDay, rez.Opis, "Ponisti");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex !=
            dataGridView1.Columns["colIzbor"].Index)
                return;
            int id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            izabranaRezervacija = lista.Where(x => x.Id == id).First();
            if (izabranaRezervacija != null)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            StringComparison comparison = StringComparison.InvariantCultureIgnoreCase;

            List<RezervacijaDTO> lr = lista.Where(x => x.Opis.StartsWith(tbxOpis.Text, comparison)).ToList();
            dataGridView1.Rows.Clear();
            foreach (RezervacijaDTO rez in lr)
            {
                dataGridView1.Rows.Add(rez.Id, rez.VrijemeRezervacije.ToShortDateString(), rez.VrijemeRezervacije.TimeOfDay, rez.Opis, "Ponisti");
            }
        }

        public void ponistiIstekleRezervacije()
        {
            DateTime now = DateTime.Now;
            DateTime up15mins = now.Add(new TimeSpan(0, 15, 0));
            List<RezervacijaDTO> listaRezervacija = BioskopUtil.getDAOFactory().getRezervacijaDAO().getAllActiveRezervacija();
            List<ProjekcijaDTO> listaProjekcija = BioskopUtil.getDAOFactory().getProjekcijaDAO().getInInterval(now, up15mins);

            foreach (ProjekcijaDTO p in listaProjekcija)
            { 
                foreach(RezervacijaDTO r in listaRezervacija)
                {
                    List<KartaDTO> listaKarata = BioskopUtil.getDAOFactory().getKartaDAO().getByProjekcijaAndRezervacija(p, r);
                    r.Aktivna = 0;
                    BioskopUtil.getDAOFactory().getRezervacijaDAO().update(r);
                    //listaRezervacija.Remove(r);

                    foreach(KartaDTO karta in listaKarata)
                    {
                        karta.Status.Id = 3;
                        BioskopUtil.getDAOFactory().getKartaDAO().update(karta);
                    }
                }
            } 
         }  
     }
}
