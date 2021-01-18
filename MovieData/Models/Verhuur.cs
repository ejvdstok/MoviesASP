using System;
using System.Collections.Generic;
using System.Text;

namespace MovieData.Models
{
    public class Verhuur
    {
        public int VerhuurId { get; set; }
        public int KlantId { get; set; }
        public int FilmId { get; set; }
        public DateTime VerhuurDatum { get; set; }

        public virtual Film FilmIdNavigation { get; set; }
        public virtual Klant KlantIdNavigation { get; set; }
    }
}
