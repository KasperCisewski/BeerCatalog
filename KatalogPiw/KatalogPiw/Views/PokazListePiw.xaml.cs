using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

using Syncfusion.Drawing;
using Syncfusion.Pdf;
using System.IO;
using Syncfusion.Pdf.Security;
using Syncfusion.Pdf.Graphics;
using System.Reflection;
using Syncfusion.Pdf.Grid;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Syncfusion.Pdf.Parsing;
using Windows.Storage;

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
            vm.CreatePDF();


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
