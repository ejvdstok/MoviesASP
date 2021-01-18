using System;
using System.Collections.Generic;
using System.Text;
using Data.Models;

namespace Data.Repositories
{
    public interface IGenreRepository
    {
        IEnumerable<Genre> GetAll();
    }
}
