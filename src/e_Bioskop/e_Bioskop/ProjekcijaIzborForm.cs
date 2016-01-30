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


        private void initDataGridView()
        {
            lista=BioskopUtil.getDAOFactory().getProjekcijaDAO().getByDateAndTime(DateTime.Now,DateTime.Now.TimeOfDay);

             dataGridView1.Rows.Clear();
            foreach (ProjekcijaDTO proj in lista)
            {
                dataGridView1.Rows.Add(proj.Id,proj.Vrijeme.TimeOfDay,proj.Film.Naziv,proj.Film.Zanr.Naziv,proj.Film.Trajanje,proj.Film.Opis,proj.Cijena,"Izaberi");
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
