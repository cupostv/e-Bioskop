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
            sala.BrojSjedistaURedu = (int)tbxBrojSjedistaUredu.Value;
            sala.BrojRedova = (int)tbxBrojRedova.Value;
            BioskopUtil.getDAOFactory().getSalaDAO().insert(sala);
        }

        private bool validate()
        {
            bool valid = true;

            if (string.IsNullOrEmpty(tbxNaziv.Text.Trim()))
            {
                valid = false;
                epNaziv.SetError(tbxNaziv, "Unesite naziv");
            }
            else
            {
                epNaziv.Clear();
            }

            return valid;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                this.Cursor = Cursors.WaitCursor;
                insertSala();
                this.Cursor = Cursors.Default;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void tbxNaziv_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxNaziv.Text.Trim()))
            {
                epNaziv.SetError(tbxNaziv, "Unesite naziv");
            }
            else
            {
                epNaziv.Clear();
            }
        }
    }
}
