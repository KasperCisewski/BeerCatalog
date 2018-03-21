using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace KatalogPiw.Models
{
    public class Gatunek
    {

        [PrimaryKey, AutoIncrement]
        public int GatunekID { get; set; }
        public string NazwaGatunku { get; set; }

        [OneToMany]
        public List<Beer> Beers { get; set; }

    }
}
