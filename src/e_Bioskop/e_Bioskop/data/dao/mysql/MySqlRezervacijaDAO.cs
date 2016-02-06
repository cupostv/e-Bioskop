using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using e_Bioskop.data.dto;
using MySql.Data.MySqlClient;

namespace e_Bioskop.data.dao.mysql
{
    public class MySqlRezervacijaDAO : RezervacijaDAO
    {

        private string getAllByProjekcijaQuerry = "select r.idRezervacija, vrijemeRezervacija, opisRezervacija,aktivnaRezervacija, "
                                                + " z.idZaposleni, datumRodjenja, korisnickoIme, lozinka, ime, "
                                                + " prezime, telefon, e_mail, aktivan "
                                                + " from rezervacija r "
                                                + " inner join zaposleni z on r.idZaposleni = z.idZaposleni "
                                                + " inner join karta k on r.idRezervacija = k.idRezervacija "
                                                + " where k.idProjekcija=?idProjekcija group by k.idRezervacija and aktivnaRezervacija=1;";

        
        private string insertQuerry = "INSERT INTO `e_bioskop`.`rezervacija` (`vrijemeRezervacija`, `idZaposleni`, `opisRezervacija`,`aktivnaRezervacija`) VALUES (?vrijemeRezervacija, ?idZaposleni, ?opisRezervacija,?aktivna);";

        private string updateQuerry = "UPDATE `e_bioskop`.`rezervacija` SET `vrijemeRezervacija`=?vrijeme, `idZaposleni`=?idZaposleni, `opisRezervacija`=?opis,`aktivnaRezervacija`=?aktivna WHERE `idRezervacija`=?idRezervacija;";

        public List<RezervacijaDTO> getAllByProjekcija(ProjekcijaDTO projekcija)
        {
            MySqlConnection connection = ConnectionPool.checkOutConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = getAllByProjekcijaQuerry;
            command.Parameters.AddWithValue("idProjekcija", projekcija.Id);
            MySqlDataReader reader = command.ExecuteReader();
            List<RezervacijaDTO> lista = new List<RezervacijaDTO>();

            while (reader.Read())
            {
                lista.Add(readerToRezervacijaDTO(reader));
            }
            reader.Close();
            ConnectionPool.checkInConnection(connection);
            return lista;
        }

        public long insert(RezervacijaDTO rezervacija)
        {
            MySqlConnection connection = ConnectionPool.checkOutConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = insertQuerry;
            command.Parameters.AddWithValue("vrijemeRezervacija", rezervacija.VrijemeRezervacije);
            command.Parameters.AddWithValue("idZaposleni", rezervacija.Zaposleni.Id);
            command.Parameters.AddWithValue("opisRezervacija", rezervacija.Opis);
            command.Parameters.AddWithValue("aktivna", rezervacija.Aktivna);
            command.ExecuteNonQuery();
            long id = command.LastInsertedId;
            if (id > 0)
                rezervacija.Id = (int)id;
            return id;
        }

        public bool update(RezervacijaDTO rezervacija)
        {
            MySqlConnection connection = ConnectionPool.checkOutConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = updateQuerry;
            command.Parameters.AddWithValue("vrijeme", rezervacija.VrijemeRezervacije);
            command.Parameters.AddWithValue("idZaposleni", rezervacija.Zaposleni.Id);
            command.Parameters.AddWithValue("opis", rezervacija.Opis);
            command.Parameters.AddWithValue("idRezervacija", rezervacija.Id);
            command.Parameters.AddWithValue("aktivna", rezervacija.Aktivna);
            int rows = command.ExecuteNonQuery();
            return rows > 0;
        }

        public static RezervacijaDTO readerToRezervacijaDTO(MySqlDataReader reader)
        {
            RezervacijaDTO rezervacija = new RezervacijaDTO();
            rezervacija.Id = reader.GetInt32("idRezervacija");
            rezervacija.VrijemeRezervacije = reader.GetDateTime("vrijemeRezervacija");
            rezervacija.Opis = reader["opisRezervacija"].ToString();
            rezervacija.Aktivna = reader.GetInt32("aktivnaRezervacija");
            rezervacija.Zaposleni = MySqlZaposleniDAO.readerToZaposleni(reader);
            return rezervacija;
        }
    }
}
