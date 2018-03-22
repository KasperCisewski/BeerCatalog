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
using System.Collections.Generic;
using KatalogPiw.Models;

namespace KatalogPiw.ViewModels
{
    public class PokazListePiwViewModel
    {
        public List<Models.Beer> Piwa { get; set; }
        public PokazListePiwViewModel()
        {
            Piwa = new List<Models.Beer>();
            //var listaPiw = new List<Models.Beer>();
            //listaPiw = Views.MainPage.ListaPiw;
            //Piwa = listaPiw;
            Piwa = KatalogPiw.App.Database.GetPiwa();
            for(int i=0;i<Piwa.Count;i++)
            {
                Piwa[i].Browary = App.Database.GetBrowary();
                Piwa[i].Gatunki = App.Database.GetGatunki();
            }

        }

        public void CreatePDF()
        {
            PdfDocument doc = new PdfDocument();

            PdfPage page = doc.Pages.Add();

            RectangleF bounds = new RectangleF(0, 0, doc.Pages[0].GetClientSize().Width, 50);

            PdfPageTemplateElement header = new PdfPageTemplateElement(bounds);

            Stream imageStream = File.OpenRead("chmielove.png");
            PdfBitmap image = new PdfBitmap(imageStream);
            PdfGraphics graphics = page.Graphics;

            graphics.DrawImage(image, 0, 0); // format 60x50




            PdfGrid pdfGrid = new PdfGrid();
            pdfGrid.Columns.Add(10);
            PdfStringFormat format = new PdfStringFormat();

            format.Alignment = PdfTextAlignment.Left;
            format.LineAlignment = PdfVerticalAlignment.Top;

            for (int i = 0; i < 10; i++)
            {
                pdfGrid.Columns[i].Format = format;
            }
            pdfGrid.Columns[0].Width = 15;
            pdfGrid.Columns[6].Width = 65;
            pdfGrid.Columns[7].Width = 200;
            pdfGrid.Headers.Add(1);

            PdfGridRow pdfGridHeader = pdfGrid.Headers[0];

            pdfGridHeader.Cells[0].Value = "Nr";
            pdfGridHeader.Cells[1].Value = "Nazwa";
            pdfGridHeader.Cells[2].Value = "Browar";
            pdfGridHeader.Cells[3].Value = "Cena netto bez rabatu";
            pdfGridHeader.Cells[4].Value = "Cena netto z rabatem";
            pdfGridHeader.Cells[5].Value = "Gatunek";
            pdfGridHeader.Cells[6].Value = "Parametry";
            pdfGridHeader.Cells[7].Value = "Opis";
            pdfGridHeader.Cells[8].Value = "Food Paring";
            // pdfGridHeader.Cells[9].Value = "Zdjecie";
            pdfGridHeader.Style.Font = new PdfStandardFont(PdfFontFamily.Helvetica, 9, PdfFontStyle.Bold);

            //add rows
            List<Beer> WyjsciowaListaPiwPDF = new List<Beer>();

            for(int i=0;i<Piwa.Count;i++)
            {
                if(Piwa[i].IsSelect==true)
                {
                    WyjsciowaListaPiwPDF.Add(Piwa[i]);
                }
            }
            
            for (int i = 0; i < WyjsciowaListaPiwPDF.Count; i++)
            {
                PdfGridRow pdfGridRow = pdfGrid.Rows.Add();
                pdfGridRow.Cells[0].Value = (i + 1).ToString();
                pdfGridRow.Cells[1].Value = WyjsciowaListaPiwPDF[i].NazwaPiwa;
                pdfGridRow.Cells[2].Value = WyjsciowaListaPiwPDF[i].Browary[WyjsciowaListaPiwPDF[i].BrowarID - 1].NazwaBrowaru;
                pdfGridRow.Cells[3].Value = WyjsciowaListaPiwPDF[i].CenaNettoBezRabatu.ToString();
                pdfGridRow.Cells[4].Value = WyjsciowaListaPiwPDF[i].CenaNettoZRabatem.ToString();
                pdfGridRow.Cells[5].Value = WyjsciowaListaPiwPDF[i].Gatunki[WyjsciowaListaPiwPDF[i].GatunekID - 1].NazwaGatunku;
                pdfGridRow.Cells[6].Value = WyjsciowaListaPiwPDF[i].Parametry;
                pdfGridRow.Cells[7].Value = WyjsciowaListaPiwPDF[i].Opis;
                pdfGridRow.Cells[8].Value = WyjsciowaListaPiwPDF[i].FoodParing;
                //pdfGridRow.Cells[9].Value = WyjsciowaListaPiwPDF[i].Image;
            }


            pdfGrid.Draw(page, 0, 80);

            //Save and close
            MemoryStream stream = new MemoryStream();

            doc.Save(stream);



            Xamarin.Forms.DependencyService.Get<Services.ISave>().SaveTextAsync("Output.pdf", "application/pdf", stream);

            doc.Close(true);
        }
    }
}
