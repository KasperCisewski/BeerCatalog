using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KatalogPiw.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PokazListePiw : ContentPage
    {
        ViewModels.PokazListePiwViewModel vm;
        
        public PokazListePiw()
        {
            vm = new ViewModels.PokazListePiwViewModel();
            BindingContext = vm;
            InitializeComponent();
        }


        private async void buttonGenerujStrone_Click(object sender, TextChangedEventArgs e)
        {
           
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
