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
        ViewModels.DodawanieGatunkuViewModel vm;
        public OknoDodawaniaGatunku()
        {
            vm = new ViewModels.DodawanieGatunkuViewModel();
            BindingContext = vm;
            InitializeComponent();
        }


        private async void buttonZapiszGatunek_Click(object sender, EventArgs e)
        {
            if (NazwaGatunku.Text == "")
            {
                DisplayAlert("blad", "powinienes wpisac nazwe gatunku", "OK");
            }
            else
            {
                string Nazwa = NazwaGatunku.Text;
                vm.DodajGatunek(Nazwa);
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