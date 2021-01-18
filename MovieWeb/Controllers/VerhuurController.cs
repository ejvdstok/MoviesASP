using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieData.Models;
using Newtonsoft.Json;
using MovieASP.Services;

namespace MovieWeb.Controllers
{
    public class VerhuurController : Controller
    {
        public IActionResult Index()
        {
            var klant = HttpContext.Session.GetString("klant");
            if (string.IsNullOrEmpty(klant))
            {
                ViewBag.klant = "geen";
            }
            else
            {
                ViewBag.klant =
                JsonConvert.DeserializeObject<Klant>(klant);
            }
            return View();
        }
        //Genre weergeven
        public IActionResult FilmGenre()
        { return View(); }

        //mandje
        public IActionResult Winkelmandje()
        { return View(); }

        //verwijderen
        public IActionResult Verwijderen()
        { return View(); }


        //afrekenen
        public IActionResult Afrekenen()
        { return View(); }
    }
    
}
