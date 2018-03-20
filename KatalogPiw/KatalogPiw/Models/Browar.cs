using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace KatalogPiw.Models
{

    public class Browar
    {
        [PrimaryKeyAttribute, AutoIncrement]
        public int BrowarID { get; set; }
        public string NazwaBrowaru { get; set; }


    }
}
