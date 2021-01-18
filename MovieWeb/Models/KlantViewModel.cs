using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MovieWeb.Models
{
    public class KlantViewModel 
    {
            [Required(ErrorMessage = "UserName is required")]
            public string Naam { get; set; }
            [Required(ErrorMessage = "Postcode is required")]
            public int Postcode { get; set; }
    }
}
