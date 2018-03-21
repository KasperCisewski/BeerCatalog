using System;
using System.Collections.Generic;

using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace KatalogPiw.Models
{
    public class Beer
    {
        [PrimaryKeyAttribute,AutoIncrement]
        public int ID { get; set; }
        public string NazwaPiwa { get; set; }
       [ForeignKey(typeof(Browar))]
        public int BrowarID { get; set; }
       [ManyToOne]
        public List<Browar> Browary { get; set; }
        public double CenaNettoBezRabatu { get; set; }
        public double CenaNettoZRabatem { get; set; }

        [ForeignKey(typeof(Gatunek))]
        public int GatunekID { get; set; }
        [ManyToOne]
        public List<Gatunek> Gatunki { get; set; }

        public string Parametry { get; set; }
        public string Opis { get; set; }
        public string FoodParing { get; set; }
       // ImageSource imageSource;

       public Beer()
        {

        }

       public Beer(string NazwaPiwa,Browar Browar,double CenaNettoBezRabatu,double CenaNettoZRabatem, Gatunek Gatunek,string Parametry,string Opis,string FoodParing)
        {
            this.NazwaPiwa = NazwaPiwa;
            this.BrowarID = Browar.BrowarID;
            this.CenaNettoBezRabatu = CenaNettoBezRabatu;
            this.CenaNettoZRabatem = CenaNettoZRabatem;
            this.GatunekID = Gatunek.GatunekID;
            this.Parametry = Parametry;
            this.Opis = Opis;
            this.FoodParing = FoodParing;
        }
    }
}
