using e_Bioskop.data.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace e_Bioskop.data.dao
{
    public interface SalaDAO
    {
        long insert(SalaDTO sala);
        bool insert(SalaDTO sala, int brojRedova, int brojSjedista);
        bool update(SalaDTO sala);
        List<SalaDTO> getAll();
        SalaDTO getById(int id);
        SalaDTO getByNaziv(string naziv);

    }
}
