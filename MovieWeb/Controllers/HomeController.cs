using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieWeb.Models;
using MovieData.Models;
using Newtonsoft.Json;
using MoviesASP.Services;

namespace MovieWeb.Controllers
{
    public class HomeController : Controller
    {

        private KlantService klantService;
        private MovieDbContext VideoVerhuurContext_;
        public HomeController(KlantService klantService, MovieDbContext context)
        {
            this.klantService = klantService;
            VideoVerhuurContext_ = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(KlantViewModel model)
        {
            var klant = VideoVerhuurContext_.Klanten
                                        .Where(k => k.PostCode == model.Postcode)
                                        .FirstOrDefault();
            ViewBag.klant = klant;

            if (klant != null && klant.Naam == model.Naam.ToUpper())
            {
                return View("Landing", klant);
            }

            return View("Landing", klant);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
