using System;
using System.Collections.Generic;
using System.Text;
using MovieData.Models;

namespace MovieData.Repositories
{
    public interface IFilmRepository
    {
        IEnumerable<Film> GetAll();
        Film Get(int id);
    }
}

