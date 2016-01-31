using e_Bioskop.data.dto;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace e_Bioskop.data.dao.mysql
{
    public class MySqlProjekcijaDAO : ProjekcijaDAO
    {
        private string getAllQuerry = "SELECT idProjekcija,vrijemeProjekcija,idFilm,cijenaProjekcija,p.idSala,aktivna,nazivSala,brojRedova,brojSjedistaURedu from projekcija p inner join sala s on p.idSala=s.idSala order by vrijemeProjekcija asc;";
        private string getByFilmQuerry = "SELECT idProjekcija,vrijemeProjekcija,idFilm,cijenaProjekcija,p.idSala,aktivna,nazivSala,brojRedova,brojSjedistaURedu from projekcija p inner join sala s on p.idSala=s.idSala where idFilm=?idFilm order by vrijemeProjekcija asc;";
        private string getByIdQuerry = "SELECT idProjekcija,vrijemeProjekcija,idFilm,cijenaProjekcija,p.idSala,aktivna,nazivSala,brojRedova,brojSjedistaURedu from projekcija p inner join sala s on p.idSala=s.idSala where idProjekcija=?id order by vrijemeProjekcija asc;";
        private string getBySalaQuerry = "SELECT idProjekcija,vrijemeProjekcija,idFilm,cijenaProjekcija,idSala from projekcija where idSala=?idSala order by vrijemeProjekcija asc;";
        private string insertQuerry = "INSERT INTO `e_bioskop`.`projekcija` (`vrijemeProjekcija`, `idFilm`, `idSala`, `cijenaProjekcija`) VALUES (?vrijeme, ?idFilm, ?idSala, ?cijena);";
        private string updateQuerry = "UPDATE `e_bioskop`.`projekcija` SET `vrijemeProjekcija`=?vrijeme, `idFilm`=?idFilm, `idSala`=?idSala, `cijenaProjekcija`=?cijena WHERE `idProjekcija`=?idProjekcija;";

        private string getByDateQuerry = "SELECT idProjekcija,vrijemeProjekcija,idFilm,cijenaProjekcija,p.idSala,aktivna,nazivSala,brojRedova,brojSjedistaURedu from projekcija p inner join sala s on p.idSala=s.idSala where Date(vrijemeProjekcija)=?datum and time(vrijemeProjekcija)>?vrijeme order by vrijemeProjekcija asc;";
        private string getInIntervalQuerry = "SELECT idProjekcija,vrijemeProjekcija,idFilm,cijenaProjekcija,p.idSala,aktivna,nazivSala,brojRedova,brojSjedistaURedu from projekcija p inner join sala s on p.idSala=s.idSala where vrijemeProjekcija>=?from and vrijemeProjekcija<=?to order by vrijemeProjekcija asc;";
        public List<ProjekcijaDTO> getAll()
        {
            MySqlConnection connection = ConnectionPool.checkOutConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = getAllQuerry;
            MySqlDataReader reader = command.ExecuteReader();
            List<ProjekcijaDTO> lista = new List<ProjekcijaDTO>();
            while (reader.Read())
            {
                lista.Add(readerToProjekcijaDTO(reader));
            }
            reader.Close();
            ConnectionPool.checkInConnection(connection);
            return lista;
        }

        public ProjekcijaDTO getById(int id)
        {
            MySqlConnection connection = ConnectionPool.checkOutConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = getByIdQuerry;
            command.Parameters.AddWithValue("id", id);
            MySqlDataReader reader = command.ExecuteReader();
            ProjekcijaDTO projekcija = null;
            while (reader.Read())
            {
                projekcija=readerToProjekcijaDTO(reader);
            }
            reader.Close();
            ConnectionPool.checkInConnection(connection);
            return projekcija;
        }

        public List<ProjekcijaDTO> getByFilm(FilmDTO film)
        {
            MySqlConnection connection = ConnectionPool.checkOutConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = getByFilmQuerry;
            command.Parameters.AddWithValue("idFilm", film.Id);
            MySqlDataReader reader = command.ExecuteReader();
            List<ProjekcijaDTO> lista = new List<ProjekcijaDTO>();
            while (reader.Read())
            {
                lista.Add(readerToProjekcijaDTO(reader,film));
            }
            reader.Close();
            ConnectionPool.checkInConnection(connection);
            return lista;
        }

        public List<ProjekcijaDTO> getBySala(SalaDTO sala)
        {
            MySqlConnection connection = ConnectionPool.checkOutConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = getBySalaQuerry;
            command.Parameters.AddWithValue("idSala", sala.Id);
            MySqlDataReader reader = command.ExecuteReader();
            List<ProjekcijaDTO> lista = new List<ProjekcijaDTO>();
            while (reader.Read())
            {
                lista.Add(readerToProjekcijaDTO(reader,sala));
            }
            reader.Close();
            ConnectionPool.checkInConnection(connection);
            return lista;
        }

        public long insert(ProjekcijaDTO projekcija)
        {
            MySqlConnection connection = ConnectionPool.checkOutConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = insertQuerry;
            command.Parameters.AddWithValue("idFilm",projekcija.Film.Id);
            command.Parameters.AddWithValue("idSala", projekcija.Sala.Id);
            command.Parameters.AddWithValue("vrijeme", projekcija.Vrijeme);
            command.Parameters.AddWithValue("cijena", projekcija.Cijena);
            command.ExecuteNonQuery();
            long id = command.LastInsertedId;
            if (id > 0)
                projekcija.Id = (int)id;
            return id;
        }

        public bool update(ProjekcijaDTO projekcija)
        {
            MySqlConnection connection = ConnectionPool.checkOutConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = updateQuerry;
            command.Parameters.AddWithValue("idFilm", projekcija.Film.Id);
            command.Parameters.AddWithValue("idSala", projekcija.Sala.Id);
            command.Parameters.AddWithValue("vrijeme", projekcija.Vrijeme);
            command.Parameters.AddWithValue("cijena", projekcija.Cijena);
            command.Parameters.AddWithValue("idProjekcija", projekcija.Id);
            int rows=command.ExecuteNonQuery();
            return rows > 0;
        }

        public static ProjekcijaDTO readerToProjekcijaDTO(MySqlDataReader reader)
        {
            ProjekcijaDTO projekcija = new ProjekcijaDTO();
            projekcija.Id = reader.GetInt32("idProjekcija");
            projekcija.Vrijeme = reader.GetDateTime("vrijemeProjekcija");
            projekcija.Cijena = reader.GetDouble("cijenaProjekcija");
            projekcija.Film =new MySqlFilmDAO().getById(reader.GetInt32("idFilm"));
            projekcija.Sala = MySqlSalaDAO.readerToSalaDTO(reader);
            return projekcija;
        }

        public static ProjekcijaDTO readerToProjekcijaDTO(MySqlDataReader reader,FilmDTO film)
        {
            ProjekcijaDTO projekcija = new ProjekcijaDTO();
            projekcija.Id = reader.GetInt32("idProjekcija");
            projekcija.Vrijeme = reader.GetDateTime("vrijemeProjekcija");
            projekcija.Cijena = reader.GetDouble("cijenaProjekcija");
            projekcija.Film =film;
            projekcija.Sala = MySqlSalaDAO.readerToSalaDTO(reader);
            return projekcija;
        }


        public static ProjekcijaDTO readerToProjekcijaDTO(MySqlDataReader reader, SalaDTO sala)
        {
            ProjekcijaDTO projekcija = new ProjekcijaDTO();
            projekcija.Id = reader.GetInt32("idProjekcija");
            projekcija.Vrijeme = reader.GetDateTime("vrijemeProjekcija");
            projekcija.Cijena = reader.GetDouble("cijenaProjekcija");
            projekcija.Film = new MySqlFilmDAO().getById(reader.GetInt32("idFilm"));
            projekcija.Sala = sala;
            return projekcija;
        }

        public List<ProjekcijaDTO> getByDateAndTime(DateTime date,TimeSpan time)
        {
            MySqlConnection connection = ConnectionPool.checkOutConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = getByDateQuerry;
            command.Parameters.AddWithValue("datum", date.Date);
            command.Parameters.AddWithValue("vrijeme", time);
            MySqlDataReader reader = command.ExecuteReader();
            List<ProjekcijaDTO> lista = new List<ProjekcijaDTO>();
            while (reader.Read())
            {
                lista.Add(readerToProjekcijaDTO(reader));
            }
            reader.Close();
            ConnectionPool.checkInConnection(connection);
            return lista;
        }

        public List<ProjekcijaDTO> getInInterval(DateTime from, DateTime to)
        {
            MySqlConnection connection = ConnectionPool.checkOutConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = getInIntervalQuerry;
            command.Parameters.AddWithValue("from", from);
            command.Parameters.AddWithValue("to", to);
            MySqlDataReader reader = command.ExecuteReader();
            List<ProjekcijaDTO> lista = new List<ProjekcijaDTO>();
            while (reader.Read())
            {
                lista.Add(readerToProjekcijaDTO(reader));
            }
            reader.Close();
            ConnectionPool.checkInConnection(connection);
            return lista;
        }
    }
}
