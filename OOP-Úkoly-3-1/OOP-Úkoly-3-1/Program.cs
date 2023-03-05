using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Úkoly_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Osoba karel = new Osoba("Karel");
            Osoba jitka = new Osoba("Jitka");
            Pes bret = new Pes("Bret ");
            karel.pes = bret;
            jitka.pes = bret;
            Console.WriteLine(karel.pes.Zestarni());
            Console.WriteLine(jitka.pes.Zestarni());
            Console.WriteLine(jitka.pes);
            Console.WriteLine(karel.pes);

            Console.ReadKey();
        }
    }
}
