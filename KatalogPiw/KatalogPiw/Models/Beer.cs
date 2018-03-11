using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace KatalogPiw.Models
{
    public class Beer
    {
        // public int ID { get; set; }
        private int _id;
        [PrimaryKey]
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                this._id = value;
            }
        }
        private string _nazwaPiwa;
        public string NazwaPiwa {
            get
            {
                return _nazwaPiwa;
            }
            set
            {
                this._nazwaPiwa = value;
            }
        }
        
        public Browar Browar { get; set; }
        public Gatunek Gatunek { get; set; }
      //  public double SkalaGorzkosci { get; set; }
      //  public double ZawartoscProcentow { get; set; }
        //  public List<string> Skladniki { get; set; }


    }
}
