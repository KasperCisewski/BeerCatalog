using System;
using System.Collections.Generic;
using System.Text;
using KatalogPiw.Models;
using KatalogPiw.Services;
using System.ComponentModel;

namespace KatalogPiw.ViewModels
{
    class DodawanieGatunkuViewModel : INotifyPropertyChanged
    {
        public List<Gatunek> GatunekList { get; set; }

        public DodawanieGatunkuViewModel()
        {
            InitializeGatunekData();
        }

        private void InitializeGatunekData()
        {
            var gatunekServices = new GatunekServices();
            GatunekList = gatunekServices.GetGatunek();
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
