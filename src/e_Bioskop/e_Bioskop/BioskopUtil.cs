using e_Bioskop.data.dao;
using e_Bioskop.data.dao.mysql;
using e_Bioskop.data.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace e_Bioskop
{
    public class BioskopUtil
    {
        private static DAOFactory daoFactory = null;

        private static ZaposleniDTO prijavljeniZaposleni = null;

        public static DAOFactory getDAOFactory()
        {
            if (daoFactory == null)
            {
                daoFactory = new MySqlDAOFactory();
            }
            return daoFactory;
        }

        public static void prijavaZaposleni(ZaposleniDTO zaposleni)
        {
            prijavljeniZaposleni = zaposleni;
        }

        public static void odjavaZaposleni()
        {
            prijavljeniZaposleni = null;
        }

        public static string sha256(string password)
        {
            System.Security.Cryptography.SHA256Managed crypt = new System.Security.Cryptography.SHA256Managed();
            System.Text.StringBuilder hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(password), 0, Encoding.UTF8.GetByteCount(password));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }
    }
}
