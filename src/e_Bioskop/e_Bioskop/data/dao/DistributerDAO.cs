using e_Bioskop.data.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace e_Bioskop.data.dao
{
    public interface DistributerDAO
    {
        DistributerDTO getById(int id);
        int insert(DistributerDTO distributer);
        List<DistributerDTO> getAll();
    }
}
