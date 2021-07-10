using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_ConsoleApp
{
    /// <summary>
    /// Fiske klassen som alle fisk skal arve fra
    /// </summary>
    public abstract class Fisk : Dyr
    {
        /// <summary>
        /// Constructor for Fisk
        /// </summary>
        /// <param name="navn">Navnet på dyretypen</param>
        public Fisk(string navn) : base(navn)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
