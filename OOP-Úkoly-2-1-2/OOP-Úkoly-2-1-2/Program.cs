using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Úkoly_2_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clovek clovek = new Clovek();
            Console.WriteLine(clovek.ToString());
            Console.WriteLine(clovek.Beh());
            Console.WriteLine(clovek.Odpocinek());
            Console.WriteLine(clovek.Beh());

            Console.ReadKey();
        }
    }
}
