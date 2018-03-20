using System;
using System.Collections.Generic;
using System.Text;
using KatalogPiw.Models;
using KatalogPiw.Services;
using System.ComponentModel;
using System.Collections.Specialized;
using System.Collections.ObjectModel;

namespace KatalogPiw.ViewModels
{
    class DodawanieGatunkuViewModel : INotifyCollectionChanged
    {

        private readonly ObservableCollection<Gatunek> _gatunkiList;
        public ObservableCollection<Gatunek> GatunkiList
        {
            get { return _gatunkiList; }

        }
        public DodawanieGatunkuViewModel()
        {
            _gatunkiList = new ObservableCollection<Gatunek>();

        }

        public void DodajGatunek(string NazwaGatunku)
        {
            Gatunek gatunek = new Gatunek();
            gatunek.NazwaGatunku = NazwaGatunku;
            _gatunkiList.Add(gatunek);
            KatalogPiw.App.Database.SaveGatunek(gatunek);
            notifyCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, gatunek));

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
