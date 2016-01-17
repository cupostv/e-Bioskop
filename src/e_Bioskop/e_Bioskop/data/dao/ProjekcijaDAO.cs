using e_Bioskop.data.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace e_Bioskop.data.dao
{
    public interface ProjekcijaDAO
    {
        List<ProjekcijaDTO> getAll();
       // List<ProjekcijaDTO> getByVrijeme(DateTime vrijeme);
        //List<ProjekcijaDTO> getInInterval(DateTime from, DateTime to);
        ProjekcijaDTO getById(int id);
        List<ProjekcijaDTO> getByFilm(FilmDTO film);
        List<ProjekcijaDTO> getBySala(SalaDTO sala);
        long insert(ProjekcijaDTO projekcija);
    }
}
