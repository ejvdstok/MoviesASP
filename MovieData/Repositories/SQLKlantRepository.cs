using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data.Models;
using MovieData.Models;

namespace Data.Repositories
{
    public class SQLKlantRepository : IKlantRepository
    {
        private MovieDbContext context;
        public SQLKlantRepository(MovieDbContext context)
        {
            this.context = context;
        }
        public Klant Get(int id)
        {
            return context.Klanten.Find(id);
        }

        public IEnumerable<Klant> GetAll()
        {
            return context.Klanten;
        }

        public Klant GetByName(string naam)
        {
            return context.Klanten
                .Where(k => k.Naam == naam.ToLower())
                .FirstOrDefault();
        }

        Klant IKlantRepository.Get(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Klant> IKlantRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        Klant IKlantRepository.GetByName(string naam)
        {
            throw new NotImplementedException();
        }
    }
}
