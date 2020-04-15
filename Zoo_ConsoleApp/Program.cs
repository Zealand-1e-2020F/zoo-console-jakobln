using System;

namespace Zoo_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Zoo!");

            Dyr elefant = new Dyr("Elefant");
            Insekt stankelben = new Insekt("Stankelben");

            Console.WriteLine(elefant.DyreNavn);
            Console.WriteLine(stankelben.InsektNavn);

        }
    }
}
