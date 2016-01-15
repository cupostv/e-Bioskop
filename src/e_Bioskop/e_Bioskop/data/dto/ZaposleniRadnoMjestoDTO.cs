using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace e_Bioskop.data.dto
{
    public class ZaposleniRadnoMjestoDTO
    {
        private ZaposleniDTO zaposleni;

        public ZaposleniDTO Zaposleni
        {
            get { return zaposleni; }
            set { zaposleni = value; }
        }
        private RadnoMjestoDTO radnoMjesto;

        public RadnoMjestoDTO RadnoMjesto
        {
            get { return radnoMjesto; }
            set { radnoMjesto = value; }
        }
        private DateTime datumZaposlenja;

        public DateTime DatumZaposlenja
        {
            get { return datumZaposlenja; }
            set { datumZaposlenja = value; }
        }
        private DateTime datumOtkaza;

        public DateTime DatumOtkaza
        {
            get { return datumOtkaza; }
            set { datumOtkaza = value; }
        }
    }
}
