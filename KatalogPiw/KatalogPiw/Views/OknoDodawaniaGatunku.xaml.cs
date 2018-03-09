using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KatalogPiw.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class OknoDodawaniaGatunku : ContentPage
	{
		public OknoDodawaniaGatunku ()
		{
			InitializeComponent ();
		}

    
        private async void buttonZapiszGatunek_Click(object sender, EventArgs e)
        {
            if (NazwaGatunku.Text == "")
            {
                DisplayAlert("blad", "powinienes wpisac nazwe gatunku", "OK");
            }
            else
            {
                Models.Gatunek gatunek = new Models.Gatunek();
                gatunek.NazwaGatunku = NazwaGatunku.Text;
                MainPage.ListaGatunkow.Add(gatunek);
                DisplayAlert("", "Dodano nowy gatunek", "OK");
            }
        }
    }
}