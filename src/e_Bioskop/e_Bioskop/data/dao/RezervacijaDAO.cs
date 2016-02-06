using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using e_Bioskop.data.dto;

namespace e_Bioskop.data.dao
{
    public interface RezervacijaDAO
    {
        List<RezervacijaDTO> getAllByProjekcija(ProjekcijaDTO projekcija);
        List<RezervacijaDTO> getAllActiveProjekcija(ProjekcijaDTO projekcija);
        long insert(RezervacijaDTO rezervacija);
        bool update(RezervacijaDTO rezervacija);
    }
}
