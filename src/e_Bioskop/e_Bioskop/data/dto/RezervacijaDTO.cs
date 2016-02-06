using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace e_Bioskop.data.dto
{
    public class RezervacijaDTO
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private DateTime vrijemeRezervacije;

        public DateTime VrijemeRezervacije
        {
            get { return vrijemeRezervacije; }
            set { vrijemeRezervacije = value; }
        }
        private ZaposleniDTO zaposleni;

        public ZaposleniDTO Zaposleni
        {
            get { return zaposleni; }
            set { zaposleni = value; }
        }
        private string opis;

        public string Opis
        {
            get { return opis; }
            set { opis = value; }
        }

        private int aktivna;

        public int Aktivna
        {
            get { return aktivna; }
            set { aktivna = value; }
        }

        
    }
}
