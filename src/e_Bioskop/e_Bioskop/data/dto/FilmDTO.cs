using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace e_Bioskop.data.dto
{
    public class FilmDTO
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
        private ZanrDTO zanr;

        internal ZanrDTO Zanr
        {
            get { return zanr; }
            set { zanr = value; }
        }
        private DateTime trajanje;

        public DateTime Trajanje
        {
            get { return trajanje; }
            set { trajanje = value; }
        }
        private StatusFilmDTO status;

        internal StatusFilmDTO Status
        {
            get { return status; }
            set { status = value; }
        }
        private DistributerDTO distributer;

        internal DistributerDTO Distributer
        {
            get { return distributer; }
            set { distributer = value; }
        }
        private string opis;

        public string Opis
        {
            get { return opis; }
            set { opis = value; }
        }
                
    }
}
