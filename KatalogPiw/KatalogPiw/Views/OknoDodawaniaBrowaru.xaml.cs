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
    public partial class OknoDodawaniaBrowaru : ContentPage
    {
        public ViewModels.DodawanieBrowaruViewModel vm;
        public OknoDodawaniaBrowaru()
        {
             vm = new ViewModels.DodawanieBrowaruViewModel();
            BindingContext = vm;
            InitializeComponent();
        }

        private async void buttonZapiszBrowar_Click(object sender, EventArgs e)
        {
            if (NazwaBrowaru.Text == "Nazwa Browaru")
            {
                DisplayAlert("blad", "powinienes wpisac nazwe browaru", "OK");
            }
            else
            {
                string Nazwa = NazwaBrowaru.Text;
                vm.DodajBrowar(Nazwa);
            }
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //    if (e.Item == null)
            //        return;

            //    await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //    //Deselect Item
            //    ((ListView)sender).SelectedItem = null;
        }
    }
}