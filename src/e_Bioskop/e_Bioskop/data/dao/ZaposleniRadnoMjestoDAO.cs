using e_Bioskop.data.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace e_Bioskop.data.dao
{
    public interface ZaposleniRadnoMjestoDAO
    {
        List<ZaposleniRadnoMjestoDTO> getRadnaMjestaZaposlenog(ZaposleniDTO zaposleni);
        List<ZaposleniRadnoMjestoDTO> getZaposleniRadnoMjesto(RadnoMjestoDTO radnoMjesto);
        bool insert(ZaposleniRadnoMjestoDTO zaposleniRadnoMjesto);
        bool update(ZaposleniRadnoMjestoDTO zaposleniRadnoMjesto,int idStaroRadnoMjesto);
    }
}
