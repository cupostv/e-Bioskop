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

        public DistributerDodajForm()
        {
            InitializeComponent();
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
            bool valid = true;

            if (string.IsNullOrEmpty(tbxNaziv.Text))
            {
                epNaziv.SetError(tbxNaziv, "Unesite naziv");
                valid = false;
            }
            else
            {
                epNaziv.Clear();
            }

            if (string.IsNullOrEmpty(tbxBrojTelefona.Text))
            {
                epBrojTelefona.SetError(tbxBrojTelefona, "Unesite broj telefona");
                valid = false;
            }
            else
            {
                epBrojTelefona.Clear();
            }

            return valid;
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

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
