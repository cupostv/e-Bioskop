using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace e_Bioskop.data.dao.mysql
{
    public class MySqlDAOFactory: DAOFactory
    {
        public override DistributerDAO getDistributerDAO()
        {
            return new MySqlDistributerDAO();
        }

        public override FilmDAO getFilmDAO()
        {
            return new MySqlFilmDAO();
        }

        public override ZaposleniDAO getZaposleniDAO()
        {
            return new MySqlZaposleniDAO ();
        }

        public override ZaposleniRadnoMjestoDAO getZaposleniRadnoMjestoDAO()
        {
            return new MySqlZaposleniRadnoMjestoDAO ();
        }

        public override RadnoMjestoDAO getRadnoMjestoDAO()
        {
            return new MySqlRadnoMjestoDAO();
        }

        public override StatusFilmDAO getStatusFilmDAO()
        {
            return new MySqlStatusFilmDAO();
        }

        public override KartaDAO getKartaDAO()
        {
            return new MySqlKartaDAO();
        }

        public override ProjekcijaDAO getProjekcijaDAO()
        {
            return new MySqlProjekcijaDAO();
        }

        public override RezervacijaDAO getRezervacijaDAO()
        {
            return new MySqlRezervacijaDAO();
        }

        public override SalaDAO getSalaDAO()
        {
            return new MySqlSalaDAO();
        }

        public override SjedisteDAO getSjedisteDAO()
        {
            return new MySqlSjedisteDAO();
        }

        public override StatusKartaDAO getStatusKartaDAO()
        {
            return new MySqlStatusKartaDAO();
        }
    }
}
