using System;
using System.Collections.Generic;
using System.Text;
using MovieData.Models;

namespace MovieData.Repositories
{
    public interface IKlantRepository
    {
        Klant Get(int id);
        Klant GetByName(string naam);
        IEnumerable<Klant> GetAll();
        /*

        public List<Klant> GetKlanten()
        {
            return db.Klants.OrderBy(k => k.Naam).ToList();
        }

        public bool BestaatKlant(string naam, string postcode)
        {
            naam = naam.ToUpper();
            int postcodeInt = Convert.ToInt32(postcode);
            var Klant = (from klant in db.Klants where klant.Naam == naam && klant.PostCode == postcodeInt select klant).FirstOrDefault();
            return Klant != null;
        }

        public Klant GetKlant(string naam, string postcode)
        {
            naam = naam.ToUpper();
            int postcodeInt = Convert.ToInt32(postcode);
            var Klant = (from klant in db.Klants where klant.Naam == naam && klant.PostCode == postcodeInt select klant).FirstOrDefault();
            if (Klant != null)
            {
                return Klant;
            }
            else
            {

                return null;
            }
        }


        public Klant GetKlantById(int? id)
        {
            var Klant = (from klant in db.Klants where klant.KlantNr == id select klant).FirstOrDefault();
            return Klant;
        }*/
    }
}