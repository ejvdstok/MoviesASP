using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MovieData.Models;

namespace MovieData.Repositories
{
    public class SQLFilmRepository : IFilmRepository
    {
        private MovieDbContext context;
        public SQLFilmRepository(MovieDbContext context)
        {
            this.context = context;
        }

        public Film Get(int id)
        {
            return context.Films
                .Where(f => f.FilmId == id)
                .FirstOrDefault();
        }

        public IEnumerable<Film> GetAll()
        {
            return context.Films;
        }

        Film IFilmRepository.Get(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Film> IFilmRepository.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
