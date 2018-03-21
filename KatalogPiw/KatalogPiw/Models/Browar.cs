using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace KatalogPiw.Models
{

    public class Browar
    {
        [PrimaryKey, AutoIncrement]
        public int BrowarID { get; set; }
        public string NazwaBrowaru { get; set; }


        [OneToMany]
        public List<Beer> Beers { get; set; }

    }
}
