﻿using e_Bioskop.data.dto;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace e_Bioskop.data.dao.mysql
{
    public class MySqlRadnoMjestoDAO : RadnoMjestoDAO
    {
        private string getByIdQuerry = "select idRadnoMjesto,nazivRadnoMjesto,opisRadnoMjesto from radno_mjesto where idRadnoMjesto=?id";
        private string getByNazivQuerry = "select idRadnoMjesto,nazivRadnoMjesto,opisRadnoMjesto from radno_mjesto where nazivRadnoMjesto=?naziv";
        private string getAllQuerry = "select idRadnoMjesto,nazivRadnoMjesto,opisRadnoMjesto from radno_mjesto;";
        private string insertQuerry = "INSERT INTO radno_mjesto (`nazivRadnoMjesto`, `opisRadnoMjesto`) VALUES (?naziv,?opis);";
        private string updateQuerry = "UPDATE radno_mjesto SET nazivRadnoMjesto=?naziv,opisRadnoMjesto=?opis WHERE `idRadnoMjesto`=?id;";

        public RadnoMjestoDTO getById(int id)
        {
            MySqlConnection connection = ConnectionPool.checkOutConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = getByIdQuerry;
            command.Parameters.AddWithValue("id", id);
            MySqlDataReader reader = command.ExecuteReader();
            RadnoMjestoDTO radnoMjesto = null;
            if (reader.Read())
            {
                radnoMjesto = readerToRadnoMjestoDTO(reader);
            }
            reader.Close();
            ConnectionPool.checkInConnection(connection);
            return radnoMjesto;
        }

        public static RadnoMjestoDTO readerToRadnoMjestoDTO(MySqlDataReader reader)
        {
            RadnoMjestoDTO radnoMjesto = new RadnoMjestoDTO();
            radnoMjesto.Id = reader.GetInt32("idRadnoMjesto");
            radnoMjesto.Naziv = reader["nazivRadnoMjesto"].ToString();
            radnoMjesto.Opis = reader["opisRadnoMjesto"].ToString();
            return radnoMjesto;
        }

        public List<RadnoMjestoDTO> getAll()
        {
            MySqlConnection connection = ConnectionPool.checkOutConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = getAllQuerry;
            MySqlDataReader reader = command.ExecuteReader();
            List<RadnoMjestoDTO> radnaMjesta = new List<RadnoMjestoDTO>();
            while (reader.Read())
            {
                radnaMjesta.Add(readerToRadnoMjestoDTO(reader));
            }
            reader.Close();
            ConnectionPool.checkInConnection(connection);
            return radnaMjesta;
        }

        public long insert(RadnoMjestoDTO radnoMjesto)
        {
            MySqlConnection connection = ConnectionPool.checkOutConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = insertQuerry;
            command.Parameters.AddWithValue("naziv", radnoMjesto.Naziv);
            command.Parameters.AddWithValue("opis", radnoMjesto.Opis);
            command.ExecuteNonQuery();
            long id = command.LastInsertedId;
            ConnectionPool.checkInConnection(connection);
            return id;
        }

        public bool update(RadnoMjestoDTO radnoMjesto)
        {
            if (radnoMjesto == null)
                return false;
            MySqlConnection connection = ConnectionPool.checkOutConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = updateQuerry;
            command.Parameters.AddWithValue("naziv", radnoMjesto.Naziv);
            command.Parameters.AddWithValue("opis", radnoMjesto.Opis);
            command.Parameters.AddWithValue("id", radnoMjesto.Id);
            command.ExecuteNonQuery();
            long id = command.LastInsertedId;
            ConnectionPool.checkInConnection(connection);
            return true;
        }

        public RadnoMjestoDTO getByNaziv(string naziv)
        {
            MySqlConnection connection = ConnectionPool.checkOutConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = getByNazivQuerry;
            command.Parameters.AddWithValue("naziv", naziv);
            MySqlDataReader reader = command.ExecuteReader();
            RadnoMjestoDTO radnoMjesto = null;
            if (reader.Read())
            {
                radnoMjesto = readerToRadnoMjestoDTO(reader);
            }
            reader.Close();
            ConnectionPool.checkInConnection(connection);
            return radnoMjesto;
        }

    }
}
