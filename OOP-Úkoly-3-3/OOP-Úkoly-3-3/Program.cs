using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Úkoly_3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Osoba panB = new Osoba("Pan Bouvier", null, null);
            Osoba paniB = new Osoba("Jackie Bouvier", null, null); ;
            Osoba dedaSi = new Osoba("Abraham Simpson", null, null);
            Osoba penSi = new Osoba("Penelope Simpson", null, null);
            Osoba homer = new Osoba("Homer Simpson", dedaSi, penSi);
            Osoba marge = new Osoba("Marge Simpson", panB, paniB);
            Osoba bart = new Osoba("Bart Simpson", homer, marge);
            Osoba herb = new Osoba("Herb Powers", dedaSi, penSi);
            Osoba selma = new Osoba("Selma Bouvier", panB, paniB);
            

            Rodokmen rodokmenBarta = new Rodokmen(bart);
            Rodokmen rodokmenHomer = new Rodokmen(homer);
            rodokmenBarta.Vypis();
            Console.WriteLine();
            rodokmenHomer.Vypis();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
