using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace e_Bioskop.data.dto
{
    public class ProjekcijaDTO
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private DateTime vrijeme;

        public DateTime Vrijeme
        {
            get { return vrijeme; }
            set { vrijeme = value; }
        }
        private FilmDTO film;

        internal FilmDTO Film
        {
            get { return film; }
            set { film = value; }
        }
        private SalaDTO sala;

        public SalaDTO Sala
        {
            get { return sala; }
            set { sala = value; }
        }
        private double cijena;

        public double Cijena
        {
            get { return cijena; }
            set { cijena = value; }
        }
    }
}
