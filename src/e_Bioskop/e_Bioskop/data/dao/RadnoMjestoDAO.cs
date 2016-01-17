using e_Bioskop.data.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace e_Bioskop.data.dao
{
    public interface RadnoMjestoDAO
    {
        RadnoMjestoDTO getById(int id);
        List<RadnoMjestoDTO> getAll();
        long insert(RadnoMjestoDTO radnoMjesto);
        bool update(RadnoMjestoDTO radnoMjesto);
        RadnoMjestoDTO getByNaziv(string naziv);
    }
}
