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
        }


        private void initDataGridView()
        {
            List<ProjekcijaDTO> lista=BioskopUtil.getDAOFactory().getProjekcijaDAO().getAll();

          //  BioskopUtil.initProjekcijaDTODataGridView(dataGridView1, lista);
             dataGridView1.Rows.Clear();
            foreach (ProjekcijaDTO proj in lista)
            {
                Button button=new Button();
                button.Name=proj.Id+"";
                button.
                dataGridView1.Rows.Add(proj.Vrijeme.TimeOfDay,proj.Film.Naziv,proj.Film.Opis,proj.Cijena,)
            }
        }
    }
}
