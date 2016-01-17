using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace e_Bioskop.data.dto
{
    public class SalaDTO
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private int aktivna;

        public int Aktivna
        {
            get { return aktivna; }
            set { aktivna = value; }
        }
        private string naziv;

        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }
    }
}
