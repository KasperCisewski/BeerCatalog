using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using static System.Net.Mime.MediaTypeNames;

namespace KatalogPiw.Models
{
    public class Beer
    {
        // public int ID { get; set; }
        [PrimaryKey]
        public int Id { get; set; }
        public string KodKreskowy { get; set; }
        public string NazwaPiwa { get; set; }
        public Browar Browar { get; set; }
        public double CenaNettoBezRabatu { get; set; }
        public double CenaNettoZRabatem { get; set; }
        public Gatunek Gatunek { get; set; }
        public string Parametry { get; set; }
        public string Opis { get; set; }
        public string FoodParing { get; set; }
        public Image Image;

       public Beer(int Id,string KodKreskowy,string NazwaPiwa,Browar Browar,double CenaNettoBezRabatu,double CenaNettoZRabatem, Gatunek Gatunek,string Parametry,string Opis,string FoodParing)
        {
            this.Id = Id;
            this.KodKreskowy = KodKreskowy;
            this.NazwaPiwa = NazwaPiwa;
            this.Browar = Browar;
            this.CenaNettoBezRabatu = CenaNettoBezRabatu;
            this.CenaNettoZRabatem = CenaNettoZRabatem;
            this.Gatunek = Gatunek;
            this.Parametry = Parametry;
            this.Opis = Opis;
            this.FoodParing = FoodParing;
        }

      //  public double SkalaGorzkosci { get; set; }
      //  public double ZawartoscProcentow { get; set; }
        //  public List<string> Skladniki { get; set; }


    }
}
