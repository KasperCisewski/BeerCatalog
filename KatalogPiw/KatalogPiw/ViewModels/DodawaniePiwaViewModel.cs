using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace KatalogPiw.ViewModels
{
    public class DodawaniePiwaViewModel:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    
        //static List<Models.Browar> _browary;
        //public static List<Models.Browar> Browary
        //{
        //    get
        //    {
        //      if(_browary==null)
        //        {
        //            _browary = new List<Models.Browar>()
        //            {
        //                new Models.Browar{NazwaBrowaru="pinta"},
        //                new Models.Browar{NazwaBrowaru="Nepomucen"},
        //                new Models.Browar{NazwaBrowaru="Czarna owaca"}
        //            };
        //        }
        //        return _browary;
        //    }
          

        //}
        //private string wybranyBrowar;
        //public string WybranyBrowar
        //{
        //    get
        //    {
        //        return wybranyBrowar;
        //    }
        //    set
        //    {
        //        if(wybranyBrowar!=value)
        //        {
        //            wybranyBrowar = value;
        //            PropertyChanged(this,new PropertyChangedEventArgs(wybranyBrowar));

        //        }
        //    }
        //}

        
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
      

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
