using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using KatalogPiw.Models;

namespace KatalogPiw.Services
{
    public class BrowarServices
    {
        public ObservableCollection<Browar> GetBrowar()
        {
            var collection = new ObservableCollection<Browar>
            {
                new Browar
                {
                    NazwaBrowaru = "Pinta"
                }
            };
            return collection;
        }
    }
}
