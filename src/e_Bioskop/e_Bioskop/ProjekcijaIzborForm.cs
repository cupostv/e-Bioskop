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
        public ProjekcijaIzborForm()
        {
            InitializeComponent();
            initDataGridView();
        }


        private void initDataGridView()
        {
            List<ProjekcijaDTO> lista=BioskopUtil.getDAOFactory().getProjekcijaDAO().getAll();

          //  BioskopUtil.initProjekcijaDTODataGridView(dataGridView1, lista);
             dataGridView1.Rows.Clear();
            foreach (ProjekcijaDTO proj in lista)
            {
                dataGridView1.Rows.Add(proj.Id,proj.Vrijeme.TimeOfDay,proj.Film.Naziv,proj.Film.Opis,proj.Cijena);
            }
        }

        private void btnIzborProjekcije_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex !=
            dataGridView1.Columns["Izaberi film"].Index)
                return;
            int id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            Console.Write(id);
        }
    }
}
