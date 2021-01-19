using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieData.Models;
using MovieData.Repositories;

namespace MovieWeb.Services
{
    public class FilmService
    {
        private IFilmRepository filmInterface;
        public FilmService(IFilmRepository filmInterface)
        {
            this.filmInterface = filmInterface;
        }
        public Film GetFilmById(int id)
        {
            return (filmInterface.Get(id));
        }
    }
}