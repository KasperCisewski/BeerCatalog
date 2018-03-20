using System;
using System.Collections.Generic;
using System.Text;
using SQLite;


namespace KatalogPiw.Models
{
    public class Gatunek
    {

        [PrimaryKeyAttribute, AutoIncrement]
        public int GatunekID { get; set; }
        public string NazwaGatunku { get; set; }

    }
}
