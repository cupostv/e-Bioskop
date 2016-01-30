using e_Bioskop.data.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MySql.Data;
using e_Bioskop.data.dao;

namespace e_Bioskop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            PrijavaForm prijava = new PrijavaForm();
            prijava.Show();
            Application.Run();
        }
    }
}
