using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using KatalogPiw.Models;
using KatalogPiw.Services;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace KatalogPiw.ViewModels
{
    public class DodawanieBrowaruViewModel:INotifyCollectionChanged 
    {
        private readonly ObservableCollection<Browar> _browarList;
        public  ObservableCollection<Browar> BrowarList
        {
            get { return _browarList; }
           
        }

        public DodawanieBrowaruViewModel()
        {
            _browarList = new ObservableCollection<Browar>();

        }
     
        public void DodajBrowar(string NazwaBrowaru)
        {
            Browar browar = new Browar();
            browar.NazwaBrowaru = NazwaBrowaru;
            _browarList.Add(browar);
            App.Database.SaveBrowar(browar);
            notifyCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, browar));
        }

        public event NotifyCollectionChangedEventHandler CollectionChanged;

        private void notifyCollectionChanged(NotifyCollectionChangedEventArgs args)
        {
            if(CollectionChanged!=null)
            {
                CollectionChanged(this, args);
            }
        }
    }
}
