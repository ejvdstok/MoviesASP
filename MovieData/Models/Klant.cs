using System;
using System.Collections.Generic;
using System.Text;

namespace MovieData.Models
{
    public class Klant
    {
        public Klant()
        {
            Verhuur = new HashSet<Verhuur>();
        }

        public int KlantId { get; set; }
        public string Naam { get; set; }
        public string Voornaam { get; set; }
        public string StraatNr { get; set; }
        public int PostCode { get; set; }
        public string Gemeente { get; set; }
        public string KlantStat { get; set; }
        public int HuurAantal { get; set; }
        public DateTime DatumLid { get; set; }
        public bool Lidgeld { get; set; }

        public virtual ICollection<Verhuur> Verhuur { get; set; }
    }
}

