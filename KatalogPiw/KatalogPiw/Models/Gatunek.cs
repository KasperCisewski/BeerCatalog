using System;
using System.Collections.Generic;
using System.Text;
using SQLite;


namespace KatalogPiw.Models
{
    public class Gatunek
    {

        [PrimaryKey, NotNull]
        public string NazwaGatunku { get; set; }

    }
}
