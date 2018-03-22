using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KatalogPiw.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : TabbedPage
	{

       // public static List<Models.Beer> ListaPiw = App.Database.GetPiwa();
        
        public MainPage ()
		{
            //for(int i=0;i<ListaPiw.Count;i++)
            //{
            //    ListaPiw[i].Browary= App.Database.GetBrowary();
            //    ListaPiw[i].Gatunki= App.Database.GetGatunki();
              
            //}
            InitializeComponent();
		}
	}
}