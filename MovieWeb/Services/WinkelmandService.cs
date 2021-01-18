using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Repositories;
using MovieData.Models;

namespace MoviesASP.Services
{
    public class WinkelmandService
    {
        private Dictionary<int, Film> films =
           new Dictionary<int, Film>();


        public WinkelmandService()
        {
        }
        public IEnumerable<Film> FindAll()
        {
            return films.Values.ToList();
        }
        public void Add(Film p)
        {
            films.Add(p.FilmId, p);
        }
        public void Delete(int id)
        {
            films.Remove(id);
        }
    }
}
