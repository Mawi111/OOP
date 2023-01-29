using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kostka kostka = new Kostka();
            Console.WriteLine("Kostka má " + kostka.vratPocetSten() + " štěn");

            for (int random = 0; random <= 6; random++)
            {
                Console.WriteLine("{0} {1} ");
            }

            
            

            Console.ReadKey();
        }
    }
}
