using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace e_Bioskop.dto
{
    public class RadnoMjestoDTO
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string naziv;

        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }
        private string opis;

        public string Opis
        {
            get { return opis; }
            set { opis = value; }
        }

    }
}
