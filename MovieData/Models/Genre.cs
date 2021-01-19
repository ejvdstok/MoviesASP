using System;
using System.Collections.Generic;


namespace MovieData.Models
{
    public partial class Genre
    {
        public Genre()
        {
            Films = new HashSet<Film>();
        }

        public int GenreId { get; set; }
        public string GenreNaam { get; set; }

        public virtual ICollection<Film> Films { get; set; }
    }
}
