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
    public partial class SalaIzmjeniForm : Form
    {
        public SalaIzmjeniForm()
        {
            InitializeComponent();
            BioskopUtil.initSalaDTOComboBox(cbNazivSale, 1);
            SalaDTO sala=BioskopUtil.getDAOFactory().getSalaDAO().
                getByNaziv(cbNazivSale.Items[cbNazivSale.SelectedIndex].ToString());
            tbxBrojRedova.Minimum = sala.BrojRedova;
            tbxBrojSjedistaUredu.Minimum = sala.BrojSjedistaURedu;
            tbxBrojRedova.Value = sala.BrojRedova;
            tbxBrojSjedistaUredu.Value = sala.BrojSjedistaURedu;
            if (sala.Aktivna == 1)
                cbAktivna.Checked = true;
            else
                cbAktivna.Checked = false;
        }

        private void cbNazivSale_SelectedIndexChanged(object sender, EventArgs e)
        {
            SalaDTO sala = BioskopUtil.getDAOFactory().getSalaDAO().
                getByNaziv(cbNazivSale.Items[cbNazivSale.SelectedIndex].ToString());
            tbxBrojRedova.Minimum = sala.BrojRedova;
            tbxBrojSjedistaUredu.Minimum = sala.BrojSjedistaURedu;
            tbxBrojRedova.Value = sala.BrojRedova;
            tbxBrojSjedistaUredu.Value = sala.BrojSjedistaURedu;
            if (sala.Aktivna == 1)
                cbAktivna.Checked = true;
            else
                cbAktivna.Checked = false;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            SalaDTO sala = BioskopUtil.getDAOFactory().getSalaDAO().
                getByNaziv(cbNazivSale.Items[cbNazivSale.SelectedIndex].ToString());
            sala.BrojRedova = (int)tbxBrojRedova.Value;
            sala.BrojSjedistaURedu = (int)tbxBrojSjedistaUredu.Value;
            if (cbAktivna.Checked)
                sala.Aktivna = 1;
            else
                sala.Aktivna = 0;
            BioskopUtil.getDAOFactory().getSalaDAO().update(sala);
            this.Close();
        }
    }
}
