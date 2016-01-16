using e_Bioskop.data.dao;
using e_Bioskop.data.dao.mysql;
using e_Bioskop.data.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace e_Bioskop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DAOFactory factory = new MySqlDAOFactory();
            FilmDTO film=factory.getFilmDAO().getById(1);
            Console.Out.WriteLine(film.Id + " " + film.Naziv + " " + film.Opis);
        }
    }
}
