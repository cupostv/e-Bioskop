using e_Bioskop.data.dao;
using e_Bioskop.data.dao.mysql;
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
    public partial class DistributerDodajForm : Form
    {
        private string opciono = "Opciono";

        public DistributerDodajForm()
        {
            InitializeComponent();

            btnDodaj.Enabled = false;

            tbxEmail.Enter += new EventHandler(tbxAdresa_Enter);
            tbxEmail.Leave += new EventHandler(tbxAdresa_Leave);

            tbxBrojTelefona.TextChanged += new EventHandler(tbxNaziv_TextChanged);

            tbxAdresa.Text = opciono;
            tbxEmail.Text = opciono;

            tbxAdresa.ForeColor = SystemColors.GrayText;
            tbxEmail.ForeColor = SystemColors.GrayText;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (insertDistributer())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private DistributerDTO controlsToDistributer()
        {
            DistributerDTO distributer = new DistributerDTO();
            distributer.Naziv = tbxNaziv.Text;
            distributer.Adresa = tbxAdresa.Text;
            distributer.Telefon = tbxBrojTelefona.Text;
            distributer.Email = tbxEmail.Text;
            return distributer;
        }

        private bool validate()
        {
            return !string.IsNullOrWhiteSpace(tbxNaziv.Text) &&
                !string.IsNullOrWhiteSpace(tbxBrojTelefona.Text);
        }

        private bool insertDistributer()
        {
            if (validate())
            {
               long id=BioskopUtil.getDAOFactory().getDistributerDAO().insert(controlsToDistributer());
               if (id > 0)
                   return true;
               else
                   return false;
            }
            return false;
        }

        private void tbxNaziv_TextChanged(object sender, EventArgs e)
        {
            if (validate())
            {
                btnDodaj.Enabled = true;
            }
            else
            {
                btnDodaj.Enabled = false;
            }
        }

        private void tbxAdresa_Enter(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.ForeColor != SystemColors.GrayText)
            {
                return;
            }
            tb.Text = "";
            tb.ForeColor = SystemColors.WindowText;
        }

        private void tbxAdresa_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            string name = tb.Name;
            if (tb.Text == "")
            {
                tb.Text = opciono;
                tb.ForeColor = SystemColors.GrayText;
            }
        }
    }
}
