using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_ConsoleApp
{
    public class Insekt : Dyr
    {
        public string InsektNavn { get; }

        public Insekt(string navn)
        {
            this.InsektNavn = navn;
        }
    }
}
