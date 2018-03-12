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

        void sa()
        {
            //Create a new document

            PdfDocument document = new PdfDocument();

            //Add a page

            PdfPage page = document.Pages.Add();

            //Create Pdf graphics for the page

            PdfGraphics graphics = page.Graphics;

            //Create a solid brush

            PdfBrush brush = new PdfSolidBrush(Syncfusion.Drawing.Color.FromArgb(255, 0, 0, 0));

            //Set the font

            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 36);

            //Draw the text

            graphics.DrawString("Hello world!", font, brush, new PointF(20, 20));

            //create the stream

            MemoryStream memoryStream = new MemoryStream();

            //save the document into stream

            document.Save(memoryStream);


            //close the document


            // Xamarin.Forms.DependencyService.Get<ISave>().Save("Output.pdf", "application/pdf", stream);
            document.Close(true);
        }

        private async void buttonGenerujStrone_Click(object sender, TextChangedEventArgs e)
        {
            PdfDocument doc = new PdfDocument();

            PdfPage page = doc.Pages.Add();
            PdfGrid pdfGrid = new PdfGrid();
            pdfGrid.Columns.Add(4);
            PdfStringFormat format = new PdfStringFormat();
            format.Alignment = PdfTextAlignment.Center;
            format.LineAlignment = PdfVerticalAlignment.Bottom;
            for (int i = 0; i < 4; i++)
            {
                pdfGrid.Columns[i].Format = format;
            }
            pdfGrid.Headers.Add(1);

            PdfGridRow pdfGridHeader = pdfGrid.Headers[0];

            pdfGridHeader.Cells[0].Value = "Nr";
            pdfGridHeader.Cells[1].Value = "Nazwa";
            pdfGridHeader.Cells[3].Value = "Gatunek";
            pdfGridHeader.Cells[2].Value = "Browar";
            pdfGridHeader.Style.Font = new PdfStandardFont(PdfFontFamily.Helvetica, 10, PdfFontStyle.Bold);

            //add rows

            for(int i=0;i<MainPage.ListaPiw.Count;i++)
            {
                PdfGridRow pdfGridRow = pdfGrid.Rows.Add();
                pdfGridRow.Cells[0].Value = MainPage.ListaPiw[i].Id.ToString();
                pdfGridRow.Cells[1].Value = MainPage.ListaPiw[i].NazwaPiwa;
                pdfGridRow.Cells[2].Value = MainPage.ListaPiw[i].Browar.NazwaBrowaru;
                pdfGridRow.Cells[3].Value = MainPage.ListaPiw[i].Gatunek.NazwaGatunku;

            }
          

            pdfGrid.Draw(page, PointF.Empty);

            //Save and close
            MemoryStream stream = new MemoryStream();

            doc.Save(stream);

           

            Xamarin.Forms.DependencyService.Get<Services.ISave>().SaveTextAsync("Output.pdf", "application/pdf", stream);

            doc.Close(true);




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
