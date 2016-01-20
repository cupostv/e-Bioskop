using e_Bioskop.data.dto;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace e_Bioskop.data.dao.mysql
{
    public class MySqlZaposleniRadnoMjestoDAO : ZaposleniRadnoMjestoDAO
    {
        private string getRadnaMjestaZaposlenogQuerry = "SELECT zrm.idRadnoMjesto,idZaposleni,datumZaposlenja,datumOtkaza,nazivRadnoMjesto,opisRadnoMjesto FROM zaposleni_radno_mjesto zrm inner join radno_mjesto r on r.idRadnoMjesto=zrm.idRadnoMjesto where idZaposleni=?idZaposleni;";
        private string getZaposleniRadnoMjestoQuerry = "SELECT z.idZaposleni,ime,prezime,datumRodjenja,korisnickoIme,e_mail,aktivan,lozinka,telefon,datumZaposlenja,datumOtkaza FROM zaposleni_radno_mjesto zrm inner join zaposleni z on  z.idZaposleni=zrm.idZaposleni where idRadnoMjesto=?idRadnoMjesto;";
        private string insertQuerry = "INSERT INTO `e_bioskop`.`zaposleni_radno_mjesto` (`idZaposleni`, `idRadnoMjesto`, `datumZaposlenja`) VALUES (?idZaposleni, ?idRadnoMjesto, ?datumZaposlenja);";
        private string insertWithDatumOtkazaQuerry = "INSERT INTO `e_bioskop`.`zaposleni_radno_mjesto` (`idZaposleni`, `idRadnoMjesto`, `datumZaposlenja`,`datumOtkaza`) VALUES (?idZaposleni, ?idRadnoMjesto, ?datumZaposlenja,?datumOtkaza);";

        public List<ZaposleniRadnoMjestoDTO> getRadnaMjestaZaposlenog(ZaposleniDTO zaposleni)
        {
            MySqlConnection connection=ConnectionPool.checkOutConnection();
            MySqlCommand command=connection.CreateCommand();
            command.CommandText=getRadnaMjestaZaposlenogQuerry;
            command.Parameters.AddWithValue("idZaposleni",zaposleni.Id);
            MySqlDataReader reader=command.ExecuteReader();
            List<ZaposleniRadnoMjestoDTO> list = new List<ZaposleniRadnoMjestoDTO>();
            while(reader.Read())
            {
                ZaposleniRadnoMjestoDTO zaposleniRadnoMjesto = readerToZaposleniRadnoMjestoDTO(reader);
                zaposleniRadnoMjesto.Zaposleni = zaposleni;
                zaposleniRadnoMjesto.RadnoMjesto = MySqlRadnoMjestoDAO.readerToRadnoMjestoDTO(reader);
                list.Add(zaposleniRadnoMjesto);
            }
            reader.Close();
            ConnectionPool.checkInConnection(connection);
            return list;
        }

        public static ZaposleniRadnoMjestoDTO readerToZaposleniRadnoMjestoDTO(MySqlDataReader reader)
        {
            ZaposleniRadnoMjestoDTO zaposleniRadnoMjesto=new ZaposleniRadnoMjestoDTO();
            zaposleniRadnoMjesto.DatumZaposlenja=reader.GetDateTime("datumZaposlenja");
            try
            {
                zaposleniRadnoMjesto.DatumOtkaza = reader.GetDateTime("datumOtkaza");
            }
            catch
            {

            }
            return zaposleniRadnoMjesto;
        }

        public List<ZaposleniRadnoMjestoDTO> getZaposleniRadnoMjesto(RadnoMjestoDTO radnoMjesto)
        {
            MySqlConnection connection = ConnectionPool.checkOutConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = getZaposleniRadnoMjestoQuerry;
            command.Parameters.AddWithValue("idRadnoMjesto", radnoMjesto.Id);
            MySqlDataReader reader = command.ExecuteReader();
            List<ZaposleniRadnoMjestoDTO> list = new List<ZaposleniRadnoMjestoDTO>();
            while (reader.Read())
            {
                ZaposleniRadnoMjestoDTO zaposleniRadnoMjesto = readerToZaposleniRadnoMjestoDTO(reader);
                zaposleniRadnoMjesto.Zaposleni = MySqlZaposleniDAO.readerToZaposleni(reader);
                zaposleniRadnoMjesto.RadnoMjesto =radnoMjesto;
                list.Add(zaposleniRadnoMjesto);
            }
            reader.Close();
            ConnectionPool.checkInConnection(connection);
            return list;
        }
        public bool insert(ZaposleniRadnoMjestoDTO zaposleniRadnoMjesto)
        {
            if (zaposleniRadnoMjesto == null)
                return false;
            MySqlConnection connection = ConnectionPool.checkOutConnection();
            MySqlCommand command = connection.CreateCommand();
            if (zaposleniRadnoMjesto.DatumOtkaza == null)
            {
                command.CommandText = insertQuerry;
            }
            else
            {
                command.CommandText = insertWithDatumOtkazaQuerry;
                command.Parameters.AddWithValue("datumOtkaza", zaposleniRadnoMjesto.DatumOtkaza);
            }
            command.Parameters.AddWithValue("idZaposleni", zaposleniRadnoMjesto.Zaposleni.Id);
            command.Parameters.AddWithValue("idRadnoMjesto", zaposleniRadnoMjesto.RadnoMjesto.Id);
            command.Parameters.AddWithValue("datumZaposlenja", zaposleniRadnoMjesto.DatumZaposlenja);
            int num=command.ExecuteNonQuery();
            ConnectionPool.checkInConnection(connection);
            return num > 0;
        }
        public bool update(ZaposleniRadnoMjestoDTO zaposleniRadnoMjesto)
        {
            return true;
        }
    }
}
