using System;
using System.Collections.Generic;
using System.Text;
using Data.Models;

namespace Data.Repositories
{
    public class SQLGenreRepository : IGenreRepository
    {
        private MovieDbContext context;
        public SQLGenreRepository(MovieDbContext context)
        {
            this.context = context;
        }
        public IEnumerable<Genre> GetAll()
        {
            return context.Genres;
        }
    }
}
