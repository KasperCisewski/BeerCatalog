using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KatalogPiw.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : TabbedPage
	{

        public static List<Models.Beer> ListaPiw = new List<Models.Beer>();
        public MainPage ()
		{
            InitializeComponent();
		}
	}
}