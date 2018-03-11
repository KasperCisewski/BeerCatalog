using System;
using System.Collections.Generic;
using System.Text;
using KatalogPiw.Models;

namespace KatalogPiw.Services
{
    public class BeerServices
    {
        public List<Beer> GetBeer()
        {
            var collection = new List<Beer>
            {
                new Beer
                {
                    Id = 1,
                    NazwaPiwa = "Lesny Lager",
                    Browar = new Browar
                    {
                        NazwaBrowaru = "Pinta"
                    },
                    Gatunek = new Gatunek
                    {
                        NazwaGatunku = "Lager"
                    }
                }
        };
            return collection;
       }
}
}
