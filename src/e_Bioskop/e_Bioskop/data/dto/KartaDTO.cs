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
        private SjedisteDTO sjediste;

        internal SjedisteDTO Sjediste
        {
            get { return sjediste; }
            set { sjediste = value; }
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
        private StatusKarteDTO status;

        internal StatusKarteDTO Status
        {
            get { return status; }
            set { status = value; }
        }

    }
}
