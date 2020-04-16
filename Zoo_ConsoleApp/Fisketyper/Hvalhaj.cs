using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_ConsoleApp
{
    public class Hvalhaj : Fisk
    {
        public Hvalhaj(string navn) : base(navn)
        {

        }

        public bool ErRovDyr()
        {
            return true;
        }
    }
}
