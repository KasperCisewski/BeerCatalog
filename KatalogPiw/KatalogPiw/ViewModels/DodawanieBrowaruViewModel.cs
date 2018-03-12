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

namespace KatalogPiw.ViewModels
{
    public class DodawanieBrowaruViewModel 
    {
    //    public ObservableCollection<Browar> BrowarList { get; set; }



    //    string inputStringBrowar = "";
    //    public DodawanieBrowaruViewModel()
    //    {
    //        InitializeBrowarData();
    //        AddBrowarCommand = new Command<string>((key) =>
    //        {
    //            key = "test";
                
    //            BrowarList.Add(new Browar { NazwaBrowaru = inputStringBrowar });
    //            OnPropertyChanged(BrowarList.Count.ToString());
    //        });
            
    //    }

    //    public string InputStringBrowar
    //    {
    //        set  //powinno byc protected?
    //        {
    //            if (inputStringBrowar != value )
    //            {
    //                inputStringBrowar = value;
    //                OnPropertyChanged("InputStringBrowar");
    //            }
    //        }
    //        get
    //        {
    //            return inputStringBrowar;
    //        }
    //    }

    //    public ICommand AddBrowarCommand { set; get; }

    //    private void InitializeBrowarData()
    //    {
    //        var browarServices = new BrowarServices();
    //        BrowarList = browarServices.GetBrowar();
    //    }

        

    //        /*
    //    public void AddBrowar(string browar)
    //    {
    //        BrowarList.Add(new Browar { NazwaBrowaru = browar });
    //    }
    //    */
    //    public event PropertyChangedEventHandler PropertyChanged;

    //    protected void OnPropertyChanged(string propertyName)
    //    {
    //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    //    }

    }
}
