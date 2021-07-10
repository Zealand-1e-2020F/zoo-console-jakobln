using System;
using Zoo_ConsoleApp.Fisketyper;

namespace Zoo_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Zoo!");

            var sild = new Sild("Sild");
            var elefant = new Elefant("Elefant");
            Insekt stankelben = new Insekt("Stankelben");
            Hvalhaj hvalhaj = new Hvalhaj("Hvalhaj");

            Console.WriteLine(sild.DyreNavn);
            Console.WriteLine(elefant.DyreNavn);
            Console.WriteLine(stankelben.DyreNavn);
            Console.WriteLine(hvalhaj.DyreNavn);
        }
    }
}
