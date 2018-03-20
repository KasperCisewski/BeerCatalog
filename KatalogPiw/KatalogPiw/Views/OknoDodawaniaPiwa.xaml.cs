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
	public partial class OknoDodawaniaPiwa : ContentPage
	{

        ViewModels.DodawaniePiwaViewModel vm;
        public OknoDodawaniaPiwa ()
		{
            vm = new ViewModels.DodawaniePiwaViewModel();

            BindingContext = vm;
            InitializeComponent();
        }
         
        private async void buttonRefreshButton_Click(object sender, TextChangedEventArgs e)
        {
            vm = new ViewModels.DodawaniePiwaViewModel();
            BindingContext = vm;
            InitializeComponent();
        }


        private async void buttonZapiszPiwo_Click(object sender, TextChangedEventArgs e)
        {
            if (NazwaPiwa.Text == null)
            {
                DisplayAlert("blad", "powinienes wpisac nazwe piwa", "OK");
            }
            else
            {
                double cenaNettoBezRabatu = Convert.ToDouble(CenaNettoBR.Text);
                double cenaNettoZRabatem = Convert.ToDouble(CenaNettoR.Text);
                vm.DodajPiwo(NazwaPiwa.Text, (Models.Browar)BrowarPicker.SelectedItem, cenaNettoBezRabatu, cenaNettoZRabatem, (Models.Gatunek)GatunekPicker.SelectedItem, Parametry.Text, Opis.Text, FoodParing.Text);
                //DisplayAlert("Dodano piwo", $"piwo o nazwie {piwo.NazwaPiwa} wyprodukowane w browarze {piwo.Browar.NazwaBrowaru} gatunku {piwo.Gatunek.NazwaGatunku} ", "ok");
            }
        }
        private async void buttonPokazListe_Click(object sender,TextChangedEventArgs e)
        {
            if(MainPage.ListaPiw.Count==0)
            {
                DisplayAlert("Error", "Nie masz zadnych piw w liscie, dodaj piwo!", "OK");
            }
            else
            {             
                await Navigation.PushAsync(new PokazListePiw());
            }
        }
    }
}