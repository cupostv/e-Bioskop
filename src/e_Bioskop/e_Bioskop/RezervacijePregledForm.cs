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

        private void initRezervacijeGridView()
        {
            lista.Clear();
            lista = BioskopUtil.getDAOFactory().getRezervacijaDAO().getAllByProjekcija(projekcija);
            foreach (RezervacijaDTO rez in lista)
            {
                dataGridView1.Rows.Add(rez.Id, rez.VrijemeRezervacije.ToShortDateString(), rez.VrijemeRezervacije.TimeOfDay, rez.Opis,"Izaberi");
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
    }
}
