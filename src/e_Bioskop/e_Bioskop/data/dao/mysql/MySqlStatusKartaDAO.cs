using e_Bioskop.data.dto;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace e_Bioskop.data.dao.mysql
{
    public class MySqlStatusKartaDAO : StatusKartaDAO
    {
        private string getByIdQuerry = "select idStatusKarta,nazivStatusKarta from status_karta where idStatusKarta=?id";
        private string getByNazivQuerry = "select idStatusKarta,nazivStatusKarta from status_karta where nazivStatusKarta like ?naziv;";
        private string getAllQuerry = "select idStatusKarta,nazivStatusKarta from status_karta";

        public StatusKartaDTO getById(int id)
        {
           MySqlConnection connection=ConnectionPool.checkOutConnection();
           MySqlCommand command = connection.CreateCommand();
           command.CommandText = getByIdQuerry;
           command.Parameters.AddWithValue("id", id);
           StatusKartaDTO status = null;
           MySqlDataReader reader=command.ExecuteReader();
           if (reader.Read())
           {
               status = readerToStatusKartaDTO(reader);
           }
           reader.Close();
           ConnectionPool.checkInConnection(connection);
           return status;
        }

        

        public List<StatusKartaDTO> getAll()
        {
            MySqlConnection connection = ConnectionPool.checkOutConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = getAllQuerry;
            List<StatusKartaDTO> lista=new List<StatusKartaDTO>();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(readerToStatusKartaDTO(reader));
            }
            reader.Close();
            ConnectionPool.checkInConnection(connection);
            return lista;
        }

        public StatusKartaDTO getByNaziv(string naziv)
        {
            MySqlConnection connection = ConnectionPool.checkOutConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = getByNazivQuerry;
            command.Parameters.AddWithValue("naziv", naziv);
            StatusKartaDTO status = null;
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                status = readerToStatusKartaDTO(reader);
            }
            reader.Close();
            ConnectionPool.checkInConnection(connection);
            return status;
        }

        public static StatusKartaDTO readerToStatusKartaDTO(MySqlDataReader reader)
        {
            StatusKartaDTO status = new StatusKartaDTO();
            status.Id = reader.GetInt32("idStatusKarta");
            status.Naziv = reader["nazivStatusKarta"].ToString();
            return status;
        }
    }
}
