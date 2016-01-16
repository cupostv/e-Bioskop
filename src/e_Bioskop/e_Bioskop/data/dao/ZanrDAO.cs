using e_Bioskop.data.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace e_Bioskop.data.dao
{
    public interface ZanrDAO
    {
        ZanrDTO getById(int id);
        int insert(ZanrDTO zanr);
    }
}
