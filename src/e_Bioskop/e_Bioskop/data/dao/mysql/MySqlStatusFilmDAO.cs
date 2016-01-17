using e_Bioskop.data.dto;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace e_Bioskop.data.dao.mysql
{
    class MySqlStatusFilmDAO : StatusFilmDAO
    {
        private static string getByIdQuerry="select idStatusFilm,nazivStatusFilm from status_film where idStatusFilm=?id";
        public StatusFilmDTO getById(int id)
        {
            MySqlConnection connection = ConnectionPool.checkOutConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = getByIdQuerry;
            command.Parameters.AddWithValue("id", id);
            MySqlDataReader reader=command.ExecuteReader();
            StatusFilmDTO status=null;
            if (reader.Read())
            {
                status = readerToStatusFilmDTO(reader);
            }
            reader.Close();
            ConnectionPool.checkInConnection(connection);
            return status;
        }

        public static StatusFilmDTO readerToStatusFilmDTO(MySqlDataReader reader)
        {
            StatusFilmDTO status = new StatusFilmDTO();
            status.Id = reader.GetInt32("idStatusFilm");
            status.Naziv = reader["nazivStatusFilm"].ToString();
            return status;
        }
    }
}
