using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieData.Models;
using MovieData.Repositories;

namespace MovieASP.Services
{
    public class GenreService
    {
        private IGenreRepository genreInterface;
        public GenreService(IGenreRepository genreInterface)
        {
            this.genreInterface = genreInterface;
        }

        public IEnumerable<Genre> GetAllGenres()
        {
            return genreInterface.GetAll();
        }
    }
}