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
        private  string getByIdQuerry="select idStatusFilm,nazivStatusFilm from status_film where idStatusFilm=?id";
        private string getAllQuerry = "select idStatusFilm,nazivStatusFilm from status_film";
        private string getByNazivQuerry = "select idStatusFilm,nazivStatusFilm from status_film where nazivStatusFilm=?naziv";
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

        public List<StatusFilmDTO> getAll()
        {
            MySqlConnection connection = ConnectionPool.checkOutConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = getAllQuerry;
            MySqlDataReader reader = command.ExecuteReader();
            List<StatusFilmDTO> lista=new List<StatusFilmDTO>();
            while (reader.Read())
            {
                lista.Add( readerToStatusFilmDTO(reader));
            }
            reader.Close();
            ConnectionPool.checkInConnection(connection);
            return lista;
        }

        public StatusFilmDTO getByNaziv(string naziv)
        {
            MySqlConnection connection = ConnectionPool.checkOutConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = getByNazivQuerry;
            command.Parameters.AddWithValue("naziv", naziv);
            MySqlDataReader reader = command.ExecuteReader();
            StatusFilmDTO status = null;
            if (reader.Read())
            {
                status = readerToStatusFilmDTO(reader);
            }
            reader.Close();
            ConnectionPool.checkInConnection(connection);
            return status;
        }
    }
}
