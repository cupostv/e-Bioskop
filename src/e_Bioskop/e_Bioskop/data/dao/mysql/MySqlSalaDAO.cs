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
        private string insertQuerry="INSERT INTO `e_bioskop`.`sala` (`aktivna`, `nazivSala`) VALUES (?aktivna, ?naziv);";
        private string getAllQuerry = "select idSala,aktivna,nazivSala from sala;";
        private string getByIdQuerry = "select idSala,aktivna,nazivSala from sala where idSala=?id;";
        private string getByNazivQuerry = "select idSala,aktivna,nazivSala from sala where nazivSala=?naziv;";
        private string updateQuerry = "UPDATE `e_bioskop`.`sala` SET `aktivna`=?aktivna, `nazivSala`=?naziv WHERE `idSala`=?id;";

        public long insert(SalaDTO sala)
        {
            MySqlConnection connection = ConnectionPool.checkOutConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = insertQuerry;
            command.Parameters.AddWithValue("aktivna", sala.Aktivna);
            command.Parameters.AddWithValue("naziv", sala.Naziv);
            command.ExecuteNonQuery();
            long id=command.LastInsertedId;
            if (id > 0)
                sala.Id = (int)id;
            return id;
        }


        public bool insert(SalaDTO sala, int brojRedova, int brojSjedista)
        {
            bool success = true;
            long id=insert(sala);
            if (id < 0)
                return false;
            sala.Id = (int)id;
            for (int i = 0; i < brojRedova; i++)
            {
                for (int j = 0; j < brojSjedista; j++)
                {
                    SjedisteDTO sjediste = new SjedisteDTO();
                    sjediste.Broj = i;
                    sjediste.Red = j;
                    sjediste.Sala = sala;
                    if (BioskopUtil.getDAOFactory().getSjedisteDAO().insert(sjediste) <= 0)
                    {
                        success = false;
                    }
                }
            }
            return success;
        }

        public bool update(SalaDTO sala)
        {
            MySqlConnection connection = ConnectionPool.checkOutConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = updateQuerry;
            command.Parameters.AddWithValue("id", sala.Id);
            command.Parameters.AddWithValue("aktivna", sala.Aktivna);
            command.Parameters.AddWithValue("naziv", sala.Naziv);
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
            return sala;
        }
    }
}
