using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace e_Bioskop.dto
{
    class SjedisteDTO
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private int red;

        public int Red
        {
            get { return red; }
            set { red = value; }
        }
        private int broj;

        public int Broj
        {
            get { return broj; }
            set { broj = value; }
        }
        private SalaDTO sala;

        public SalaDTO Sala
        {
            get { return sala; }
            set { sala = value; }
        }
    }
}
