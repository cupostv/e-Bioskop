using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace e_Bioskop.data.dto
{
    public class DistributerDTO
    {
        int id;

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
        private string adresa;

        public string Adresa
        {
            get { return adresa; }
            set { adresa = value; }
        }
        private string telefon;

        public string Telefon
        {
            get { return telefon; }
            set { telefon = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
