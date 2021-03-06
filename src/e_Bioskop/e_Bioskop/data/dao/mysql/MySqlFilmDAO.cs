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
        private string getAllQuerry = "SELECT idFilm,trajanjeFilm,nazivFilm,opisFilm,f.idDistributer,nazivDistributer,adresaDistributer,telefonDistributer,e_mailDistributer,f.idStatusFilm,nazivStatusFilm,f.idZanr,nazivZanr from film f inner join distributer d on f.idDistributer=d.idDistributer inner join status_film sf on f.idStatusFilm=sf.idStatusFilm inner join zanr z on f.idZanr=z.idZanr ;";
        private string insertQuerry = "INSERT INTO `e_bioskop`.`film` (`trajanjeFilm`, `idDistributer`, `nazivFilm`, `idStatusFilm`, `opisFilm`, `idZanr`) VALUES (?trajanje, ?idDistributer, ?naziv, ?idStatus, ?opis, ?idZanr);";
        private string updateQuerry = "UPDATE `e_bioskop`.`film` SET `trajanjeFilm`=?trajanje, `idDistributer`=?idDistributer,`nazivFilm`=?naziv, `idStatusFilm`=?idStatusFilm, `opisFilm`=?opis, `idZanr`=?idZanr WHERE `idFilm`=?idFilm;";

        private string getByDistributerQuerry = "SELECT idFilm,trajanjeFilm,nazivFilm,opisFilm,f.idStatusFilm,nazivStatusFilm,f.idZanr,nazivZanr from film f inner join distributer d on f.idDistributer=d.idDistributer inner join status_film sf on f.idStatusFilm=sf.idStatusFilm inner join zanr z on f.idZanr=z.idZanr where f.idDistributer=?idDistributer;";
        private string getByStatusQuerry = "SELECT idFilm,trajanjeFilm,nazivFilm,opisFilm,f.idDistributer,nazivDistributer,adresaDistributer,telefonDistributer,e_mailDistributer,f.idStatusFilm,nazivStatusFilm,f.idZanr,nazivZanr from film f inner join distributer d on f.idDistributer=d.idDistributer inner join status_film sf on f.idStatusFilm=sf.idStatusFilm inner join zanr z on f.idZanr=z.idZanr where f.idStatusFilm=?idStatus;";
        private string getByZanrQuerry = "SELECT idFilm,trajanjeFilm,nazivFilm,opisFilm,f.idDistributer,nazivDistributer,adresaDistributer,telefonDistributer,e_mailDistributer,f.idStatusFilm,nazivStatusFilm from film f inner join distributer d on f.idDistributer=d.idDistributer inner join status_film sf on f.idStatusFilm=sf.idStatusFilm inner join zanr z on f.idZanr=z.idZanr where f.idZanr=?idZanr;";
        private string searchByNazivQuerry = "SELECT idFilm,trajanjeFilm,nazivFilm,opisFilm,f.idDistributer,nazivDistributer,adresaDistributer,telefonDistributer,e_mailDistributer,f.idStatusFilm,nazivStatusFilm,f.idZanr,nazivZanr from film f inner join distributer d on f.idDistributer=d.idDistributer inner join status_film sf on f.idStatusFilm=sf.idStatusFilm inner join zanr z on f.idZanr=z.idZanr where nazivFilm like ?naziv;";

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
                film.Zanr = MySqlZanrDAO.readerToZanrDTO(reader);
                film.Status = MySqlStatusFilmDAO.readerToStatusFilmDTO(reader);
                film.Distributer = MySqlDistributerDAO.readerToDistributer(reader);
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

        public List<FilmDTO> getAll()
        {
            MySqlConnection connection = ConnectionPool.checkOutConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = getAllQuerry;
            MySqlDataReader reader = command.ExecuteReader();
            List<FilmDTO> lista = new List<FilmDTO>();
            while (reader.Read())
            {
                FilmDTO film = readerToFilmDTO(reader);
                film.Zanr = MySqlZanrDAO.readerToZanrDTO(reader);
                film.Status = MySqlStatusFilmDAO.readerToStatusFilmDTO(reader);
                film.Distributer = MySqlDistributerDAO.readerToDistributer(reader);
                lista.Add(film);
            }
            reader.Close();
            ConnectionPool.checkInConnection(connection);
            return lista;
        }

        public List<FilmDTO> getAllByDistributer(DistributerDTO distributer)
        {
            MySqlConnection connection = ConnectionPool.checkOutConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = getByDistributerQuerry;
            command.Parameters.AddWithValue("idDistributer", distributer.Id);
            MySqlDataReader reader = command.ExecuteReader();
            List<FilmDTO> lista = new List<FilmDTO>();
            while(reader.Read())
            {
                FilmDTO film = readerToFilmDTO(reader);
                film.Zanr = MySqlZanrDAO.readerToZanrDTO(reader);
                film.Status = MySqlStatusFilmDAO.readerToStatusFilmDTO(reader);
                film.Distributer = distributer;
                lista.Add(film);
            }
            reader.Close();
            ConnectionPool.checkInConnection(connection);
            return lista;
        }

        public List<FilmDTO> getAllByStatusFilm(StatusFilmDTO status)
        {
            MySqlConnection connection = ConnectionPool.checkOutConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = getByStatusQuerry;
            command.Parameters.AddWithValue("idStatus", status.Id);
            MySqlDataReader reader = command.ExecuteReader();
            List<FilmDTO> lista = new List<FilmDTO>();
            while (reader.Read())
            {
                FilmDTO film = readerToFilmDTO(reader);
                film.Zanr = MySqlZanrDAO.readerToZanrDTO(reader);
                film.Status = status;
                film.Distributer = MySqlDistributerDAO.readerToDistributer(reader);

                lista.Add(film);
            }
            reader.Close();
            ConnectionPool.checkInConnection(connection);
            return lista;
        }

        public List<FilmDTO> getAllByZanr(ZanrDTO zanr)
        {
            MySqlConnection connection = ConnectionPool.checkOutConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = getByZanrQuerry;
            command.Parameters.AddWithValue("idZanr", zanr.Id);
            MySqlDataReader reader = command.ExecuteReader();
            List<FilmDTO> lista = new List<FilmDTO>();
            while (reader.Read())
            {
                FilmDTO film = readerToFilmDTO(reader);
                film.Zanr = zanr;
                film.Status = MySqlStatusFilmDAO.readerToStatusFilmDTO(reader); ;
                film.Distributer = MySqlDistributerDAO.readerToDistributer(reader);
                lista.Add(film);
            }
            reader.Close();
            ConnectionPool.checkInConnection(connection);
            return lista;
        }

        public static FilmDTO readerToFilmDTO(MySqlDataReader reader)
        {
            FilmDTO film = new FilmDTO();
            film.Id = reader.GetInt32("idFilm");
            film.Naziv = reader["nazivFilm"].ToString();
            film.Opis = reader["opisFilm"].ToString();
            film.Trajanje = reader.GetInt32("trajanjeFilm");
            return film;
        }


        public int insert(FilmDTO film)
        {
            if (film == null)
                return 0;
            MySqlConnection connection = ConnectionPool.checkOutConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = insertQuerry;
            command.Parameters.AddWithValue("naziv", film.Naziv);
            command.Parameters.AddWithValue("trajanje", film.Trajanje);
            command.Parameters.AddWithValue("idDistributer", film.Distributer.Id);
            command.Parameters.AddWithValue("idZanr", film.Zanr.Id);
            command.Parameters.AddWithValue("opis", film.Opis);
            command.Parameters.AddWithValue("idStatus", film.Status.Id);
            command.ExecuteNonQuery();
            int id =(int) command.LastInsertedId;
            ConnectionPool.checkInConnection(connection);
            return id;
        }

        public bool update(FilmDTO film)
        {
            if (film == null)
                return false;
            MySqlConnection connection = ConnectionPool.checkOutConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = updateQuerry;
            command.Parameters.AddWithValue("naziv", film.Naziv);
            command.Parameters.AddWithValue("trajanje", film.Trajanje);
            command.Parameters.AddWithValue("idDistributer", film.Distributer.Id);
            command.Parameters.AddWithValue("idZanr", film.Zanr.Id);
            command.Parameters.AddWithValue("opis", film.Opis);
            command.Parameters.AddWithValue("idStatusFilm", film.Status.Id);
            command.Parameters.AddWithValue("idFilm", film.Id);
            int rows=command.ExecuteNonQuery();
            ConnectionPool.checkInConnection(connection);
            return rows>0;
        }
        public List<FilmDTO> searchByNaziv(string naziv)
        {
            MySqlConnection connection = ConnectionPool.checkOutConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = searchByNazivQuerry;
            command.Parameters.AddWithValue("naziv", "%"+naziv+"%");
            MySqlDataReader reader = command.ExecuteReader();
            List<FilmDTO> lista = new List<FilmDTO>();
            while (reader.Read())
            {
                FilmDTO film = readerToFilmDTO(reader);
                film.Distributer = MySqlDistributerDAO.readerToDistributer(reader);
                film.Zanr = MySqlZanrDAO.readerToZanrDTO(reader);
                film.Status = MySqlStatusFilmDAO.readerToStatusFilmDTO(reader);
                lista.Add(film);
            }
            reader.Close();
            ConnectionPool.checkInConnection(connection);
            return lista;
        }

    }
}
