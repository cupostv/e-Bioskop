﻿using e_Bioskop.data.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace e_Bioskop.data.dao
{
    public interface StatusFilmDAO
    {
        StatusFilmDTO getById(int id);

    }
}
