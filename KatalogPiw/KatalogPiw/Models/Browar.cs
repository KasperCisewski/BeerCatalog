using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace KatalogPiw.Models
{
    public class Browar
    {
        private string _nazwaBrowaru;
        [PrimaryKey, NotNull]
        public string NazwaBrowaru
        {
            get
            {
                return _nazwaBrowaru;
            }
            set
            {
                this._nazwaBrowaru = value;
            }

        }
        /*
        public Browar(string nazwaBrowaru)
        {
            this.NazwaBrowaru = nazwaBrowaru;
        }
        */
    }
}
