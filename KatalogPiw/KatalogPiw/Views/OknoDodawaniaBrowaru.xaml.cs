using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using KatalogPiw.ViewModels;

namespace KatalogPiw.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class OknoDodawaniaBrowaru : ContentPage
	{
        ViewModels.DodawanieBrowaruViewModel vm;
		public OknoDodawaniaBrowaru ()
		{
           // vm = new ViewModels.DodawanieBrowaruViewModel();
			InitializeComponent ();
		}
        private void EditorTextChanged(object sender, TextChangedEventArgs e)
        {
            var text = e.OldTextValue;
            var newText = e.NewTextValue;
            
        }

        /*
        private async void buttonZapiszBrowar_Click(object sender, EventArgs e)
        {
            if (NazwaBrowaru.Text == "Nazwa Browaru")
            {
                DisplayAlert("blad", "powinienes wpisac nazwe browaru", "OK");
            }
            else
            {
                AddBrowar(NazwaBrowaru.Text);

                /*
                Models.Browar browar = new Models.Browar();
                browar.NazwaBrowaru = NazwaBrowaru.Text;
                MainPage.ListaBrowarow.Add(browar);
               
                DisplayAlert("", "Dodano nowy browar", "OK");
            }
            
        }*/

    }
}