using e_Bioskop.data.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace e_Bioskop.data.dao
{
    public interface StatusKartaDAO
    {
        StatusKartaDTO getById(int id);
        
        List<StatusKartaDTO> getAll();

        StatusKartaDTO getByNaziv(string naziv);
    }
}
