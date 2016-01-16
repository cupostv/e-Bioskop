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
            ZanrDTO zanr=BioskopUtil.getDAOFactory().getZanrDAO().getById(1);
            FilmDTO film = BioskopUtil.getDAOFactory().getFilmDAO().getById(1);
        }
    }
}
