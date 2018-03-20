using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using SQLite;
using Xamarin.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace KatalogPiw.Models
{
    public class Beer
    {
        [PrimaryKeyAttribute,AutoIncrement]
        public int ID { get; set; }
        public string NazwaPiwa { get; set; }
        public Browar Browar { get; set; }
        public double CenaNettoBezRabatu { get; set; }
        public double CenaNettoZRabatem { get; set; }
       // [ForeignKey(typeof(Gatunek))]
        public int GatunekID { get; set; }
        //[ManyToMany(typeof(Gatunek))] tu chyba lista
        public Gatunek Gatunek { get; set; }
        public string Parametry { get; set; }
        public string Opis { get; set; }
        public string FoodParing { get; set; }
       // ImageSource imageSource;

       public Beer()
        {

        }

       public Beer(int Id,string NazwaPiwa,Browar Browar,double CenaNettoBezRabatu,double CenaNettoZRabatem, Gatunek Gatunek,string Parametry,string Opis,string FoodParing)
        {
            this.ID = Id;
            this.NazwaPiwa = NazwaPiwa;
            this.Browar = Browar;
            this.CenaNettoBezRabatu = CenaNettoBezRabatu;
            this.CenaNettoZRabatem = CenaNettoZRabatem;
            this.Gatunek = Gatunek;
            this.Parametry = Parametry;
            this.Opis = Opis;
            this.FoodParing = FoodParing;
        }
    }
}
