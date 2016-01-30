using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using e_Bioskop.data.dto;
using MySql.Data.MySqlClient;

namespace e_Bioskop.data.dao.mysql
{
    class MySqlRezervacijaDAO : RezervacijaDAO
    {
        public static RezervacijaDTO readerToRezervacijaDTO(MySqlDataReader reader)
        {
            RezervacijaDTO rezervacija = new RezervacijaDTO();
            rezervacija.Id = reader.GetInt32("idRezervacija");
            rezervacija.VrijemeRezervacije = reader.GetDateTime("vrijemeRezervacija");
            rezervacija.Opis = reader["opisRezervacija"].ToString();
            rezervacija.Zaposleni = MySqlZaposleniDAO.readerToZaposleni(reader);
            return rezervacija;
        }
    }
}
