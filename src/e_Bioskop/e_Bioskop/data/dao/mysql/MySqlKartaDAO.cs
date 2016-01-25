using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using e_Bioskop.data.dto;
using MySql.Data.MySqlClient;

namespace e_Bioskop.data.dao.mysql
{
    public class MySqlKartaDAO : KartaDAO
    {
        private string getByProjekcijaQuerry = "select k.idKarta, datumProdaje, k.idZaposleni, korisnickoIme, lozinka, ime, prezime, "
                                       + " datumRodjenja, telefon, e_mail, aktivan, s.idSjediste, redSjediste, brojSjediste, "
                                       + " sk.idStatusKarta, NazivStatusKarta "
                                       + " from karta k "
                                       + " inner join zaposleni z on k.idZaposleni = z.idZaposleni "
                                       + " inner join sjediste s on k.idSjediste = s.idSjediste "
                                       + " inner join sala sl on s.idSala = sl.idSala "
                                       + " inner join projekcija p on k.idProjekcija = p.idProjekcija "
                                       + " inner join status_karta sk on k.idStatusKarta = sk.idStatusKarta "
                                       + " where p.idProjekcija=?idProjekcija;";

        private string getByZaposleniQuerry = "select k.idKarta, datumProdaje, s.idSjediste, redSjediste, brojSjediste, "
                                       + " sk.idStatusKarta, NazivStatusKarta p.idProjekcija, idFilm, vrijemeProjekcija, cijenaProjekcija, "
                                       + " sl.idSala, nazivSala, aktivna,"
                                       + " from karta k "
                                       + " inner join zaposleni z on k.idZaposleni = z.idZaposleni "
                                       + " inner join sjediste s on k.idSjediste = s.idSjediste "
                                       + " inner join sala sl on s.idSala = sl.idSala "
                                       + " inner join projekcija p on k.idProjekcija = p.idProjekcija "
                                       + " inner join status_karta sk on k.idStatusKarta = sk.idStatusKarta "
                                       + " where z.idZaposleni=?idZaposleni;";
                                        // veliki broj entiteta ukljucen - POKUSATI REDUKOVATI
        private string insertQuery = "INSERT INTO `e_bioskop`.`karta` (`cijenaKarta`, `datumProdaje`, `idZaposleni`, `idSjediste`, `idProjekcija`, `idRezervacija`, `idStatusKarta`) VALUES (?cijenaKarta, ?datumProdaje, ?idZaposleni, ?idSjediste, ?idProjekcija, ?idRezervacija, ?idStatusKarta);";

        public List<KartaDTO> getByProjekcija(ProjekcijaDTO projekcija)
        {
            MySqlConnection connection = ConnectionPool.checkOutConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = getByProjekcijaQuerry;
            command.Parameters.AddWithValue("idProjekcija", projekcija.Id);
            MySqlDataReader reader = command.ExecuteReader();
            List<KartaDTO> lista = new List<KartaDTO>();

            while (reader.Read())
            {
                lista.Add(readerToKartaDTO(reader, projekcija));
            }
            reader.Close();
            ConnectionPool.checkInConnection(connection);
            return lista;
        }

        public List<KartaDTO> getByZaposleni(ZaposleniDTO zaposleni)
        {
            MySqlConnection connection = ConnectionPool.checkOutConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = getByZaposleniQuerry;
            command.Parameters.AddWithValue("idZaposleni", zaposleni.Id);
            MySqlDataReader reader = command.ExecuteReader();
            List<KartaDTO> lista = new List<KartaDTO>();

            while (reader.Read())
            { 
                lista.Add(readerToKartaDTO(reader, zaposleni));
            }
            reader.Close();
            ConnectionPool.checkInConnection(connection);
            return lista;
        }

        public List<KartaDTO> getByStatus(StatusKartaDTO status)
        {
            List<KartaDTO> lista = new List<KartaDTO>();

            return lista;
            
        }

        public KartaDTO getById(int id)
        {
            KartaDTO karta = new KartaDTO();

            return karta;
        }

        public long insert(KartaDTO karta)
        {
            MySqlConnection connection = ConnectionPool.checkOutConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = insertQuery;
            command.Parameters.AddWithValue("cijenaKarta", karta.Cijena);
            command.Parameters.AddWithValue("datumProdaje", karta.DatumProdaje);
            command.Parameters.AddWithValue("idZaposleni", karta.Zaposleni.Id);
            command.Parameters.AddWithValue("idSjediste", karta.Sjediste.Id);
            command.Parameters.AddWithValue("idProjekcija", karta.Projekcija.Id);
            command.Parameters.AddWithValue("idRezervacija", karta.Rezervacija.Id);
            command.Parameters.AddWithValue("idStatusKarta", karta.Status.Id);
            command.ExecuteNonQuery();
            long id = command.LastInsertedId;
            if (id > 0)
                karta.Id = (int)id;
            return id;
        }

        public static KartaDTO readerToKartaDTO(MySqlDataReader reader, ProjekcijaDTO projekcija)
        {
            KartaDTO karta = new KartaDTO();
            karta.Id = reader.GetInt32("idKarta");
            karta.DatumProdaje = reader.GetDateTime("datumProdaje");
            karta.Zaposleni = MySqlZaposleniDAO.readerToZaposleni(reader);
            karta.Sjediste = MySqlSjedisteDAO.readerToSjedisteDTO(reader, projekcija.Sala);
            karta.Projekcija = projekcija;
            //karta.Rezervacija = MySqlRezervacijaDAO.readerToRezervacijaDTO(reader);
            karta.Status = MySqlStatusKartaDAO.readerToStatusKartaDTO(reader);
            return karta;
        }

        public static KartaDTO readerToKartaDTO(MySqlDataReader reader, ZaposleniDTO zaposleni)
        {
            KartaDTO karta = new KartaDTO();
            karta.Id = reader.GetInt32("idKarta");
            karta.DatumProdaje = reader.GetDateTime("datumProdaje");
            karta.Zaposleni = zaposleni;
            karta.Sjediste = MySqlSjedisteDAO.readerToSjedisteDTO(reader);
            karta.Projekcija = MySqlProjekcijaDAO.readerToProjekcijaDTO(reader);
            //karta.Rezervacija = MySqlRezervacijaDAO.readerToRezervacijaDTO(reader);
            karta.Status = MySqlStatusKartaDAO.readerToStatusKartaDTO(reader);
            return karta;
        }
    }
}
