using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace KatalogPiw.Models
{
    public class Browar
    {
        [PrimaryKey, NotNull]
        public string NazwaBrowaru { get; set; }
    }
}
