using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using KatalogPiw.Models;

namespace KatalogPiw.Services
{
    public class GatunekServices
    {
        public List<Gatunek> GetGatunek()
        {
            var collection = new List<Gatunek>
            {
                new Gatunek
                {
                    NazwaGatunku = "Lager"
                }
            };
        return collection;
        }
    }
}
