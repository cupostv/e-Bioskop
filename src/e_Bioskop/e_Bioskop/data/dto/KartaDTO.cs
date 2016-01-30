using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace e_Bioskop.data.dto
{
    public class KartaDTO
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private DateTime datumProdaje;

        public DateTime DatumProdaje
        {
            get { return datumProdaje; }
            set { datumProdaje = value; }
        }
        private ZaposleniDTO zaposleni;

        public ZaposleniDTO Zaposleni
        {
            get { return zaposleni; }
            set { zaposleni = value; }
        }
        private ProjekcijaDTO projekcija;

        public ProjekcijaDTO Projekcija
        {
            get { return projekcija; }
            set { projekcija = value; }
        }
        private RezervacijaDTO rezervacija;

        internal RezervacijaDTO Rezervacija
        {
            get { return rezervacija; }
            set { rezervacija = value; }
        }
        private StatusKartaDTO status;

        internal StatusKartaDTO Status
        {
            get { return status; }
            set { status = value; }
        }

        private double cijena;

        internal double Cijena
        {
            get { return cijena; }
            set { cijena = value; }
        }

        private int brojReda;

        internal int BrojReda
        {
            get { return brojReda; }
            set { brojReda = value; }
        }

        private int brojSjedista;

        internal int BrojSjedista
        {
            get { return brojSjedista; }
            set { brojSjedista = value; }
        }
    }
}
