﻿using e_Bioskop.data.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace e_Bioskop.data.dao
{
    public interface FilmDAO
    {
        FilmDTO getById(int id);
        List<FilmDTO> getAll();
        int insert(FilmDTO film);
    }
}
