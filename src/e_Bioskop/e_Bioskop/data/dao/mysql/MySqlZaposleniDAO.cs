using e_Bioskop.data.dto;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace e_Bioskop.data.dao.mysql
{
    public class MySqlZaposleniDAO : ZaposleniDAO
    {
        private string getByIdQuerry = "SELECT idZaposleni,ime,prezime,datumRodjenja,korisnickoIme,e_mail,aktivan,lozinka,telefon FROM e_bioskop.zaposleni where idZaposleni=?id;";
        private string insertQuerry = "INSERT INTO `e_bioskop`.`zaposleni` (`ime`, `prezime`, `datumRodjenja`, `korisnickoIme`, `e_mail`, `aktivan`, `lozinka`) VALUES (?ime, ?prezime, ?datumRodjenja, ?korisnickoIme, ?eMail, ?aktivan, ?lozinka);";
        public ZaposleniDTO getById(int id)
        {
            MySqlConnection connection = ConnectionPool.checkOutConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = getByIdQuerry;
            command.Parameters.AddWithValue("id", id);
            MySqlDataReader reader=command.ExecuteReader();
            ZaposleniDTO zaposleni = null;
            if (reader.Read())
            {
                zaposleni = readerToZaposleni(reader);
            }
            reader.Close();
            ConnectionPool.checkInConnection(connection);
            return zaposleni;
        }

        public static ZaposleniDTO readerToZaposleni(MySqlDataReader reader)
        {
            ZaposleniDTO zapoleni = new ZaposleniDTO();
            zapoleni.Ime = reader["ime"].ToString();
            zapoleni.Prezime = reader["prezime"].ToString();
            zapoleni.DatumRodjenja = reader.GetDateTime("datumRodjenja");
            zapoleni.KorisnickoIme = reader["korisnickoIme"].ToString();
            zapoleni.Lozinka = reader["lozinka"].ToString();
            zapoleni.Telefon = reader["telefon"].ToString();
            zapoleni.Email = reader["e_mail"].ToString();
            zapoleni.Aktivan = reader.GetInt32("aktivan");
            return zapoleni;
        }
        
        public long insert(ZaposleniDTO zaposleni)
        {
            if (zaposleni == null)
                return 0;
            MySqlConnection connection = ConnectionPool.checkOutConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = insertQuerry;
            command.Parameters.AddWithValue("ime", zaposleni.Ime);
            command.Parameters.AddWithValue("prezime", zaposleni.Prezime);
            command.Parameters.AddWithValue("datumRodjenja", zaposleni.DatumRodjenja);
            command.Parameters.AddWithValue("korisnickoIme", zaposleni.KorisnickoIme);
            command.Parameters.AddWithValue("eMail", zaposleni.Email);
            command.Parameters.AddWithValue("aktivan", zaposleni.Aktivan);
            command.Parameters.AddWithValue("lozinka", zaposleni.Lozinka);
            command.ExecuteNonQuery();
            long id = command.LastInsertedId;
            ConnectionPool.checkInConnection(connection);
            return id;
        }
        
    }
}
