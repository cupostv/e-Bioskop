using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using e_Bioskop.data.dto;

namespace e_Bioskop.data.dao
{
    public interface KartaDAO
    {
        List<KartaDTO> getByProjekcija(ProjekcijaDTO projekcija);

        List<KartaDTO> getByZaposleni(ZaposleniDTO zaposleni);

        List<KartaDTO> getByStatus(StatusKartaDTO status);

        KartaDTO getById(int id);

        long insert(KartaDTO karta);

    }
}
