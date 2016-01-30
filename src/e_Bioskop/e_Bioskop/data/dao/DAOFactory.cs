using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace e_Bioskop.data.dao
{
    public abstract class DAOFactory
    {
        public abstract ZaposleniDAO getZaposleniDAO();
        public abstract ZaposleniRadnoMjestoDAO getZaposleniRadnoMjestoDAO();
        public abstract RadnoMjestoDAO getRadnoMjestoDAO();
        public abstract FilmDAO getFilmDAO();
        public abstract StatusFilmDAO getStatusFilmDAO();
        public abstract DistributerDAO getDistributerDAO();
        public abstract SalaDAO getSalaDAO();
        public abstract ProjekcijaDAO getProjekcijaDAO();
        public abstract KartaDAO getKartaDAO();
        public abstract StatusKartaDAO getStatusKartaDAO();
        public abstract RezervacijaDAO getRezervacijaDAO();
        public abstract ZanrDAO getZanrDAO();
    }
}
