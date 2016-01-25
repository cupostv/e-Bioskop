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
                                       +  " r.idRezervacija, vrijemeRezervacija, opisRezervacija, sk.idStatusKarta, NazivStatusKarta "
                                       + " from karta k "
                                       + " inner join zaposleni z on k.idZaposleni = z.idZaposleni "
                                       + " inner join sjediste s on k.idSjediste = s.idSjediste "
                                       + " inner join sala sl on s.idSala = sl.idSala "
                                       + " inner join projekcija p on k.idProjekcija = p.idProjekcija "
                                       + " inner join rezervacija r on k.idRezervacija = r.idRezervacija "
                                       + " inner join status_karta sk on k.idStatusKarta = sk.idStatusKarta "
                                       + " where p.idProjekcija=?idProjekcija;";

        private string getByZaposleniQuerry = "select k.idKarta, datumProdaje, s.idSjediste, redSjediste, brojSjediste, "
                                       + " r.idRezervacija, vrijemeRezervacija, opisRezervacija, sk.idStatusKarta, NazivStatusKarta "
                                       + " from karta k "
                                       + " inner join zaposleni z on k.idZaposleni = z.idZaposleni "
                                       + " inner join sjediste s on k.idSjediste = s.idSjediste "
                                       + " inner join sala sl on s.idSala = sl.idSala "
                                       + " inner join projekcija p on k.idProjekcija = p.idProjekcija "
                                       + " inner join rezervacija r on k.idRezervacija = r.idRezervacija "
                                       + " inner join status_karta sk on k.idStatusKarta = sk.idStatusKarta "
                                       + " where z.idZaposleni=?idZaposleni;";

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
            long id = 0;

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
            karta.Rezervacija = MySqlRezervacijaDAO.readerToRezervacijaDTO(reader);
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
            karta.Rezervacija = MySqlRezervacijaDAO.readerToRezervacijaDTO(reader);
            karta.Status = MySqlStatusKartaDAO.readerToStatusKartaDTO(reader);
            return karta;
        }
    }
}
