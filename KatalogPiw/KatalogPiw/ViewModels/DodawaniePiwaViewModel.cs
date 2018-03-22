using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;
using KatalogPiw.Models;
using KatalogPiw.ViewModels;
using System.Collections.Specialized;
using System.Linq;

namespace KatalogPiw.ViewModels
{
    public class DodawaniePiwaViewModel:INotifyCollectionChanged
    {


        public List<Models.Browar> Browary { get; set; }
        public List<Models.Gatunek> Gatunki { get; set; }


        private readonly ObservableCollection<Beer> _piwaList;
        public ObservableCollection<Beer> PiwaList
        {
            get { return _piwaList; }

        }


        public DodawaniePiwaViewModel()
        {
            _piwaList = new ObservableCollection<Beer>();
            Browary = new List<Models.Browar>();
            Browary = App.Database.GetBrowary();

            Gatunki = new List<Gatunek>();
            Gatunki = App.Database.GetGatunki();

            //for (int i = 0; i < _piwaList.Count; i++)
            //{
            //    ListaPiw[i].Browary = App.Database.GetBrowary();
            //    ListaPiw[i].Gatunki = App.Database.GetGatunki();

            //}
            for (int i=0;i<App.Database.GetPiwa().Count;i++)
            {
                _piwaList.Add(App.Database.GetPiwo(i));
                _piwaList[i].Browary = App.Database.GetBrowary();
                _piwaList[i].Gatunki = App.Database.GetGatunki();
            }



        }


        public static void Init()
        {

        }

        public void DodajPiwo(string nazwaPiwa, Models.Browar browar,double cenaNettoBR,double cenaNettoR,Models.Gatunek gatunek,string parametry,string opis,string foodParing)
        {
            Models.Beer beer = new Models.Beer(nazwaPiwa,browar,cenaNettoBR,cenaNettoR,gatunek,parametry,opis,foodParing);
            beer.Browary = App.Database.GetBrowary();
            beer.Gatunki = App.Database.GetGatunki();
            _piwaList.Add(beer);
            KatalogPiw.App.Database.SaveBeer(beer);
            notifyCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, beer));

           // Views.MainPage.ListaPiw.Add(beer);
        }

        public event NotifyCollectionChangedEventHandler CollectionChanged;

        private void notifyCollectionChanged(NotifyCollectionChangedEventArgs args)
        {
            if (CollectionChanged != null)
            {
                CollectionChanged(this, args);
            }
        }
    }
}
