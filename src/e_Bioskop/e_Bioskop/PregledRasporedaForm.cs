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
    public partial class PregledRasporedaForm : Form
    {
        private List<ProjekcijaDTO> listaProjekcija;
        public PregledRasporedaForm()
        {
            InitializeComponent();
            listaProjekcija = BioskopUtil.getDAOFactory().getProjekcijaDAO().getAll();
            List<ProjekcijaDTO> lista = listaProjekcija.Where(x => x.Vrijeme.Date == dtpDatum.Value.Date).ToList();
            BioskopUtil.initProjekcijaDTOListView(lvProjekcije, lista);
        }

        private void dtpDatum_ValueChanged(object sender, EventArgs e)
        {
            List<ProjekcijaDTO> lista = listaProjekcija.Where(x => x.Vrijeme.Date == dtpDatum.Value.Date).ToList();
            BioskopUtil.initProjekcijaDTOListView(lvProjekcije, lista);
        }



        
    }
}
