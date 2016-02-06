using e_Bioskop.data.dto;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace e_Bioskop.data.dao.mysql
{
    public class MySqlSalaDAO : SalaDAO
    {
        private string insertQuerry="INSERT INTO `e_bioskop`.`sala` (`aktivna`, `nazivSala`,`brojRedova`,`brojSjedistaURedu`) VALUES (?aktivna, ?naziv,?brojRedova,?brojSjedistaURedu);";
        private string getAllQuerry = "select idSala,aktivna,nazivSala,brojRedova,brojSjedistaURedu from sala where aktivna=1;";
        private string getAllForChangeQuerry = "select idSala,aktivna,nazivSala,brojRedova,brojSjedistaURedu from sala;";
        private string getByIdQuerry = "select idSala,aktivna,nazivSala,brojRedova,brojSjedistaURedu from sala where idSala=?id;";
        private string getByNazivQuerry = "select idSala,aktivna,nazivSala,brojRedova,brojSjedistaURedu from sala where nazivSala=?naziv;";
        private string updateQuerry = "UPDATE `e_bioskop`.`sala` SET `aktivna`=?aktivna, `nazivSala`=?naziv,brojRedova=?brojRedova,brojSjedistaURedu=?brojSjedistaURedu WHERE `idSala`=?id;";

        public long insert(SalaDTO sala)
        {
            MySqlConnection connection = ConnectionPool.checkOutConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = insertQuerry;
            command.Parameters.AddWithValue("aktivna", sala.Aktivna);
            command.Parameters.AddWithValue("naziv", sala.Naziv);
            command.Parameters.AddWithValue("brojRedova", sala.BrojRedova);
            command.Parameters.AddWithValue("brojSjedistaURedu", sala.BrojSjedistaURedu);
            command.ExecuteNonQuery();
            long id=command.LastInsertedId;
            if (id > 0)
                sala.Id = (int)id;
            return id;
        }



        public bool update(SalaDTO sala)
        {
            MySqlConnection connection = ConnectionPool.checkOutConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = updateQuerry;
            command.Parameters.AddWithValue("id", sala.Id);
            command.Parameters.AddWithValue("aktivna", sala.Aktivna);
            command.Parameters.AddWithValue("naziv", sala.Naziv);
            command.Parameters.AddWithValue("brojRedova", sala.BrojRedova);
            command.Parameters.AddWithValue("brojSjedistaURedu", sala.BrojSjedistaURedu);
            int rows=command.ExecuteNonQuery();
            if (rows > 0)
                return true;
            return false;
        }

        public List<SalaDTO> getAll()
        {
            MySqlConnection connection = ConnectionPool.checkOutConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = getAllQuerry;
            MySqlDataReader reader = command.ExecuteReader();
            List<SalaDTO> lista = new List<SalaDTO>();
            while (reader.Read())
            {
                lista.Add(readerToSalaDTO(reader));
            }
            reader.Close();
            ConnectionPool.checkInConnection(connection);
            return lista;   
        }

        public List<SalaDTO> getAllForChange()
        {
            MySqlConnection connection = ConnectionPool.checkOutConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = getAllForChangeQuerry;
            MySqlDataReader reader = command.ExecuteReader();
            List<SalaDTO> lista = new List<SalaDTO>();
            while (reader.Read())
            {
                lista.Add(readerToSalaDTO(reader));
            }
            reader.Close();
            ConnectionPool.checkInConnection(connection);
            return lista;
        }

        public SalaDTO getById(int id)
        {
            MySqlConnection connection = ConnectionPool.checkOutConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = getByIdQuerry;
            command.Parameters.AddWithValue("id", id);
            MySqlDataReader reader = command.ExecuteReader();
            SalaDTO sala=null;
            if (reader.Read())
            {
                sala=readerToSalaDTO(reader);
            }
            reader.Close();
            ConnectionPool.checkInConnection(connection);
            return sala;
        }

        public SalaDTO getByNaziv(string naziv)
        {
            MySqlConnection connection = ConnectionPool.checkOutConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = getByNazivQuerry;
            command.Parameters.AddWithValue("naziv", naziv);
            MySqlDataReader reader = command.ExecuteReader();
            SalaDTO sala = null;
            if (reader.Read())
            {
                sala = readerToSalaDTO(reader);
            }
            reader.Close();
            ConnectionPool.checkInConnection(connection);
            return sala;
        }
 

        public static SalaDTO readerToSalaDTO(MySqlDataReader reader)
        {
            SalaDTO sala = new SalaDTO();
            sala.Id = reader.GetInt32("idSala");
            sala.Aktivna = reader.GetInt32("aktivna");
            sala.Naziv = reader["nazivSala"].ToString();
            sala.BrojRedova = reader.GetInt32("brojRedova");
            sala.BrojSjedistaURedu = reader.GetInt32("brojSjedistaURedu");
            return sala;
        }
    }
}
