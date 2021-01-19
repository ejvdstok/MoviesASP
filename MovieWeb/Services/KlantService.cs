using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieData.Repositories;

namespace MoviesASP.Services
{
        public class KlantService
        {
            private IKlantRepository klantInterface;
            public KlantService(IKlantRepository klantInterface)
            {
                this.klantInterface = klantInterface;
            }   
    }
}
