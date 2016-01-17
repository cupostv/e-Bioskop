using e_Bioskop.data.dto;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace e_Bioskop.data.dao.mysql
{
    public class MySqlDistributerDAO : DistributerDAO
    {
        private string getByIdQuerry = "SELECT idDistributer,nazivDistributer,adresaDistributer,telefonDistributer,e_mailDistributer FROM e_bioskop.distributer where idDistributer=?id;";

        private string insertQuerry = "INSERT INTO `e_bioskop`.`distributer` (`nazivDistributer`, `adresaDistributer`, `telefonDistributer`, `e_mailDistributer`) VALUES (?naziv, ?adresa, ?telefon,?eMail);";
        private string getAllQuerry = "SELECT idDistributer,nazivDistributer,adresaDistributer,telefonDistributer,e_mailDistributer FROM e_bioskop.distributer";

        public DistributerDTO getById(int id)
        {
            MySqlConnection connection = ConnectionPool.checkOutConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText=getByIdQuerry;
            command.Parameters.AddWithValue("id",id);
            MySqlDataReader reader=command.ExecuteReader();
            DistributerDTO distributer=null;
            if(reader.Read())
            {
                distributer=readerToDistributer(reader);
            }
            reader.Close();
            ConnectionPool.checkInConnection(connection);
            return distributer;
        
        }
        public static DistributerDTO readerToDistributer(MySqlDataReader reader)
        {
            DistributerDTO distributer = new DistributerDTO();
            distributer.Id = reader.GetInt32("idDistributer");
            distributer.Naziv = reader["nazivDistributer"].ToString();
            distributer.Adresa = reader["adresaDistributer"].ToString();
            distributer.Telefon = reader["telefonDistributer"].ToString();
            distributer.Email = reader["e_mailDistributer"].ToString();
            return distributer;
        }

        public long insert(DistributerDTO distributer)
        {
            if (distributer == null)
            {
                throw new MySqlDAOException();
            }
            MySqlConnection connection = ConnectionPool.checkOutConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = insertQuerry;
            command.Parameters.AddWithValue("naziv", distributer.Naziv);
            command.Parameters.AddWithValue("adresa", distributer.Adresa);
            command.Parameters.AddWithValue("telefon", distributer.Telefon);
            command.Parameters.AddWithValue("eMail", distributer.Email);
            command.ExecuteNonQuery();
            long id = command.LastInsertedId;
            ConnectionPool.checkInConnection(connection);
            return id;
        }

        public List<DistributerDTO> getAll()
        {
            MySqlConnection connection = ConnectionPool.checkOutConnection();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = getAllQuerry;
            MySqlDataReader reader=command.ExecuteReader();
            List<DistributerDTO> lista = new List<DistributerDTO>();
            while (reader.Read())
            {
                lista.Add(readerToDistributer(reader));
            }
            reader.Close();
            ConnectionPool.checkInConnection(connection);
            return lista;
        }
    }
}
