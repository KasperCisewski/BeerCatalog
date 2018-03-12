using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace KatalogPiw.ViewModels
{
    public class DodawaniePiwaViewModel
    {


        public List<Models.Browar> Browary { get; set; }
        public List<Models.Gatunek> Gatunki { get; set; }



        public DodawaniePiwaViewModel()
        {
            Browary = new List<Models.Browar>();
            var listaBrowarow = new List<Models.Browar>();
            listaBrowarow = Views.MainPage.ListaBrowarow;
            Browary = listaBrowarow;

            Gatunki = new List<Models.Gatunek>();
            var listaGatunkow = new List<Models.Gatunek>();
            listaGatunkow = Views.MainPage.ListaGatunkow;
            Gatunki = listaGatunkow;


        }
    }
}
