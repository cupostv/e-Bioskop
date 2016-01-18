using e_Bioskop.data.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace e_Bioskop.data.dao
{
    public interface SjedisteDAO
    {
        
        SjedisteDTO getById(int id);
        List<SjedisteDTO> getBySala(SalaDTO sala);
        long insert(SjedisteDTO sjediste);
        bool update(SjedisteDTO sjediste);
    }
}
