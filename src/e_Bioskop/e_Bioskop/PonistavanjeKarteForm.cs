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
    public partial class PonistavanjeKarteForm : Form
    {
        public PonistavanjeKarteForm()
        {
            InitializeComponent();
        }

        private void btnPonisti_Click(object sender, EventArgs e)
        {
            KartaDTO karta = BioskopUtil.getDAOFactory().getKartaDAO().getById(int.Parse(textBox1.Text));
            if (karta == null|| karta.Id==0)
            {
                MessageBox.Show(this, "Karta ne postoji", "");
            }
            else
            {
                karta.Status = BioskopUtil.getDAOFactory().getStatusKartaDAO().getByNaziv("Ponistena");
                BioskopUtil.getDAOFactory().getKartaDAO().update(karta);
            }
        }
    }
}
