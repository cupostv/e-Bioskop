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
            insertDistributer();
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
            return true;
        }

        private void insertDistributer()
        {
            if (validate())
            {
                BioskopUtil.getDAOFactory().getDistributerDAO().insert(controlsToDistributer());
            }
        }
    }
}
