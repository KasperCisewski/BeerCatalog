using System;
using System.Collections.Generic;
using System.Text;

namespace KatalogPiw.ViewModels
{
    public class PokazListePiwViewModel
    {
        public List<Models.Beer> Piwa { get; set; }
        public PokazListePiwViewModel()
        {
            Piwa = new List<Models.Beer>();
            //var listaPiw = new List<Models.Beer>();
            //listaPiw = Views.MainPage.ListaPiw;
            //Piwa = listaPiw;
            Piwa = KatalogPiw.App.Database.GetPiwa();

        }
    }
}
