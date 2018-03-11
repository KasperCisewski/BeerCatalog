using System;
using System.Collections.Generic;
using System.Text;
using SQLite;


namespace KatalogPiw.Models
{
    public class Gatunek
    {
        public string _nazwaGatunku;
        [PrimaryKey, NotNull]
        public string NazwaGatunku {
            get
            {
                return _nazwaGatunku;
            }
            set
            {
                this._nazwaGatunku = value;
            }

        }
        /*
        public Gatunek(string nazwaGatunku)
        {
            this.NazwaGatunku = nazwaGatunku;
        }
        */
    }
}
