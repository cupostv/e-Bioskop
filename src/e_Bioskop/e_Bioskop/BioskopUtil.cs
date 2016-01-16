using e_Bioskop.data.dao;
using e_Bioskop.data.dao.mysql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace e_Bioskop
{
    public class BioskopUtil
    {
        private static DAOFactory daoFactory=null;
        public static DAOFactory getDAOFactory()
        {
            if (daoFactory == null)
            {
                daoFactory = new MySqlDAOFactory();
            }
            return daoFactory;
        }
    }
}
