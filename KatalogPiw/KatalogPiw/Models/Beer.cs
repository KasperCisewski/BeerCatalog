using System;
using System.Collections.Generic;
using System.Text;

namespace KatalogPiw.Models
{
    public class Beer
    {
        // public int ID { get; set; }
        public string NazwaPiwa { get; set; }
        public Browar Browar { get; set; }
        public Gatunek Gatunek { get; set; }
      //  public double SkalaGorzkosci { get; set; }
      //  public double ZawartoscProcentow { get; set; }
        //  public List<string> Skladniki { get; set; }

        public Beer()
        {
        }
    }
}
