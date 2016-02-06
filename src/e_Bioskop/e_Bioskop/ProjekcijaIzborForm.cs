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
    public partial class ProjekcijaIzborForm : Form
    {
        List<ProjekcijaDTO> lista = null;

        public List<ProjekcijaDTO> Lista
        {
            get { return lista; }
            set { lista = value; }
        }

        ProjekcijaDTO izabranaProjekcija = null;
        private int p=0;

        public ProjekcijaDTO IzabranaProjekcija
        {
            get { return izabranaProjekcija; }
            set { izabranaProjekcija = value; }
        }

        public ProjekcijaIzborForm()
        {
            InitializeComponent();
            initDataGridView();
        }

        public ProjekcijaIzborForm(int p)
        {
            this.p = 1;
            InitializeComponent();
            initDataGridView();

        }


        private void initDataGridView()
        {
            if (p == 0)
            {
                DateTime sutra = DateTime.Today+new TimeSpan(1,0,0,0);
                TimeSpan razlika = sutra - DateTime.Now;
                lista = BioskopUtil.getDAOFactory().getProjekcijaDAO().getInInterval(DateTime.Now, sutra);
                dataGridView1.Columns["colDatum"].Visible=true;
            }
            else
            {
                lista = BioskopUtil.getDAOFactory().getProjekcijaDAO().getInInterval(DateTime.Now, DateTime.Now + new TimeSpan(7, 0, 0, 0));
                dataGridView1.Columns["colDatum"].Visible = true;
            }

             dataGridView1.Rows.Clear();
            foreach (ProjekcijaDTO proj in lista)
            {
                dataGridView1.Rows.Add(proj.Id,proj.Vrijeme.ToShortDateString(),proj.Vrijeme.TimeOfDay,proj.Film.Naziv,proj.Film.Zanr.Naziv,proj.Film.Trajanje,proj.Sala.Naziv,proj.Film.Opis,proj.Cijena,"Izaberi");
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex !=
            dataGridView1.Columns["colIzbor"].Index)
                return;
            int id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            izabranaProjekcija = lista.Where(x => x.Id == id).First();
            if(izabranaProjekcija!=null)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }


    }
}
