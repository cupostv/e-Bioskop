using e_Bioskop.data.dto;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace e_Bioskop.data.dao.mysql
{
    public class MySqlZanrDAO : ZanrDAO
    {
        private string getByIdQuerry = "select idZanr,nazivZanr from zanr where idZanr=?id;";
        private string getByNazivQuerry = "select idZanr,nazivZanr from zanr where nazivZanr=?naziv;";
        private string insertQuerry = "INSERT INTO `e_bioskop`.`zanr` (`nazivZanr`) VALUES (?naziv);";
        private string getAllQuerry = "select idZanr,nazivZanr from zanr;";
        public ZanrDTO getById(int id)
        {
            MySqlConnection connection = ConnectionPool.checkOutConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = getByIdQuerry;
            command.Parameters.AddWithValue("id", id);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                ZanrDTO zanr=readerToZanrDTO(reader);
                reader.Close();
                ConnectionPool.checkInConnection(connection);
                return zanr;
            }
            return null;
        }

        public static ZanrDTO readerToZanrDTO(MySqlDataReader reader)
        {
            ZanrDTO zanr = new ZanrDTO();
            zanr.Id = reader.GetInt32("idZanr");
            zanr.Naziv = reader["nazivZanr"].ToString();
            return zanr;
        }


        public int insert(ZanrDTO zanr)
        {
            if(zanr==null)
                return 0;
            MySqlConnection conn = ConnectionPool.checkOutConnection();
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = insertQuerry;
            command.Parameters.AddWithValue("naziv", zanr.Naziv);
            command.ExecuteNonQuery();
            int id =(int) command.LastInsertedId;
            ConnectionPool.checkInConnection(conn);
            return id;
        }

        public List<ZanrDTO> getAll()
        {
            MySqlConnection connection = ConnectionPool.checkOutConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = getAllQuerry;
            MySqlDataReader reader = command.ExecuteReader();
            List<ZanrDTO> lista = new List<ZanrDTO>();
            while (reader.Read())
            {
                lista.Add(readerToZanrDTO(reader));
            }
            reader.Close();
            ConnectionPool.checkInConnection(connection);
            return lista;
        }

        public ZanrDTO getByNaziv(string naziv)
        {
            MySqlConnection connection = ConnectionPool.checkOutConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = getByNazivQuerry;
            command.Parameters.AddWithValue("naziv",naziv);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                ZanrDTO zanr = readerToZanrDTO(reader);
                reader.Close();
                ConnectionPool.checkInConnection(connection);
                return zanr;
            }
            return null;
        }
    }
}
