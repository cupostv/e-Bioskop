using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace e_Bioskop.data.dto
{
    public class ZaposleniDTO
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string korisnickoIme;
        public string KorisnickoIme
        {
            get { return korisnickoIme; }
            set { korisnickoIme = value; }
        }

        private string lozinka;
        public string Lozinka
        {
            get { return lozinka; }
            set { lozinka = value; }
        }

        private string ime;
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        private string prezime;
        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        private DateTime datumRodjenja;
        public DateTime DatumRodjenja
        {
            get { return datumRodjenja; }
            set { datumRodjenja = value; }
        }

        private string telefon;
        public string Telefon
        {
            get { return telefon; }
            set { telefon = value; }
        }

        private string eMail;
        public string Email
        {
            get { return eMail; }
            set { eMail = value; }
        }

        private int aktivan;
        public int Aktivan
        {
            get { return aktivan; }
            set { aktivan = value; }
        }

    }
}
