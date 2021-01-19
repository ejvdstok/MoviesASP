using System;
using System.Collections.Generic;
using System.Text;
using MovieData.Models;

namespace MovieData.Repositories
{
    public class SQLGenreRepository : IGenreRepository
    {
        private MovieDbContext context;
        public SQLGenreRepository(MovieDbContext context)
        {
            this.context = context;
        }
        public Genre Get(int id)
        {
            return context.Genres.Find(id);
        }

        public IEnumerable<Genre> GetAll()
        {
            return context.Genres;
        }
    }
}
