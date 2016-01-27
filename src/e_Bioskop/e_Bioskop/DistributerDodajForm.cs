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
        private DistributerDTO distributer = null;

        public DistributerDodajForm()
        {
            InitializeComponent();
        }

        public DistributerDodajForm(DistributerDTO distributer)
        {
            InitializeComponent();

            this.Text = "Izmjena distributera";
            tbxNaziv.Text = distributer.Naziv;
            tbxAdresa.Text = distributer.Adresa;
            tbxEmail.Text = distributer.Email;
            tbxBrojTelefona.Text = distributer.Telefon;
            this.distributer = distributer;

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (distributer == null)
            {
                if (insertDistributer())
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                if (updateDistributer())
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void controlsToDistributer(DistributerDTO distributer)
        {
            distributer.Naziv = tbxNaziv.Text;
            distributer.Adresa = tbxAdresa.Text;
            distributer.Telefon = tbxBrojTelefona.Text;
            distributer.Email = tbxEmail.Text;
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
                DistributerDTO distributer = new DistributerDTO();
                controlsToDistributer(distributer);
               long id=BioskopUtil.getDAOFactory().getDistributerDAO().insert(distributer);
               if (id > 0)
                   return true;
               else
                   return false;
            }
            return false;
        }

        private bool updateDistributer()
        {
            controlsToDistributer(distributer);
            BioskopUtil.getDAOFactory().getDistributerDAO().update(distributer);
            return true;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
