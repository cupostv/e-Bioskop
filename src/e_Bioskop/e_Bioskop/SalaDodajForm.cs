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
    public partial class SalaDodajForm : Form
    {
        public SalaDodajForm()
        {
            InitializeComponent();
        }

        private void insertSala()
        {
            SalaDTO sala = new SalaDTO();
            sala.Naziv = tbxNaziv.Text;
            BioskopUtil.getDAOFactory().getSalaDAO().insert(sala, int.Parse(tbxBrojRedova.Value.ToString()), int.Parse(tbxBrojSjedistaUredu.Value.ToString()));

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            insertSala();
        }
    }
}
