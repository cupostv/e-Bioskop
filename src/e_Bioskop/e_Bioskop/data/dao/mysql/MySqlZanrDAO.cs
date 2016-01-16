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
        private string getByIdQuerry = "select idZanr,naziv from zanr where idZanr=?id";
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

        public ZanrDTO readerToZanrDTO(MySqlDataReader reader)
        {
            ZanrDTO zanr = new ZanrDTO();
            zanr.Id = reader.GetInt32("idZanr");
            zanr.Naziv = reader["naziv"].ToString();
            return zanr;
        }


    }
}
