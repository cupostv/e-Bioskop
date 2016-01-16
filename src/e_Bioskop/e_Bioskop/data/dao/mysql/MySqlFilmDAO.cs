﻿using e_Bioskop.data.dto;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace e_Bioskop.data.dao.mysql
{
    public class MySqlFilmDAO : FilmDAO
    {
        private string getByIdQuerry = "SELECT idFilm,trajanjeFilm,nazivFilm,opisFilm,f.idDistributer,nazivDistributer,adresaDistributer,telefonDistributer,e_mailDistributer,f.idStatusFilm,nazivStatusFilm,f.idZanr,nazivZanr from film f inner join distributer d on f.idDistributer=d.idDistributer inner join status_film sf on f.idStatusFilm=sf.idStatusFilm inner join zanr z on f.idZanr=z.idZanr where idFilm=?id;";

        private string insertQuerry = "INSERT INTO `e_bioskop`.`film` (`trajanje`, `idDistributer`, `nazivFilm`, `idStatusFilm`, `opisFilm`, `idZanr`) VALUES (?trajanje, ?idDistributer, ?naziv, ?idStatus, ?opis, ?idZanr);";
        public FilmDTO getById(int id)
        {
            MySqlConnection connection=ConnectionPool.checkOutConnection();
            MySqlCommand command=connection.CreateCommand();
            command.CommandText = getByIdQuerry;
            command.Parameters.AddWithValue("id", id);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                FilmDTO film = readerToFilmDTO(reader);
                reader.Close();
                ConnectionPool.checkInConnection(connection);
                return film;
            }
            else
            {
                reader.Close();
                ConnectionPool.checkInConnection(connection);
                return null;
            }
        }

        public static FilmDTO readerToFilmDTO(MySqlDataReader reader)
        {
            FilmDTO film = new FilmDTO();
            film.Id = reader.GetInt32("idFilm");
            film.Naziv = reader["nazivFilm"].ToString();
            film.Opis = reader["opisFilm"].ToString();
            film.Zanr = MySqlZanrDAO.readerToZanrDTO(reader);
            film.Status = MySqlStatusFilmDAO.readerToStatusFilmDTO(reader);
            film.Distributer = MySqlDistributerDAO.readerToDistributer(reader);
            return film;
        }

        public bool insert(FilmDTO film)
        {
            if (film == null)
                return false;
            MySqlConnection connection = ConnectionPool.checkOutConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = insertQuerry;
            command.Parameters.AddWithValue("naziv", film.Naziv);
            command.Parameters.AddWithValue("trajanje", film.Trajanje);
            command.Parameters.AddWithValue("idDistributer", film.Distributer.Id);
            command.Parameters.AddWithValue("idZanr", film.Zanr.Id);
            command.Parameters.AddWithValue("opis", film.Opis);
            return true;
        }
    }
}
