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
    public partial class AdministratorForm : Form
    {
        public AdministratorForm()
        {
            InitializeComponent();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            BioskopUtil.odjavaZaposleni();
            this.Close();

            PrijavaForm prijava = new PrijavaForm();
            prijava.Show();
        }

    }
}
