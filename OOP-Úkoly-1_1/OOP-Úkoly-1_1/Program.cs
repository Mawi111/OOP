using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Úkoly_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kalkulacka kalkulacka = new Kalkulacka();

            Console.Write("Zadej 1. číslo: ");
            kalkulacka.a = float.Parse(Console.ReadLine());
            Console.Write("Zadej 2. číslo: ");
            kalkulacka.b = float.Parse(Console.ReadLine());
            Console.WriteLine("Součet: " + kalkulacka.Soucet());
            Console.WriteLine("Rozdil: " + kalkulacka.Rozdil());
            Console.WriteLine("Soucin: " + kalkulacka.Soucin());
            Console.WriteLine("Podil: " + kalkulacka.Podil());

            Console.ReadKey();
        }
    }
}
