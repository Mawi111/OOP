using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kostka sestistenka = new Kostka();
            Kostka desetistenka = new Kostka(10);

            Console.WriteLine(sestistenka);
            for (int i = 0; i < 6; i++)
            {
                Console.Write(sestistenka.hod() + " ");
            }


            Console.WriteLine("\n\n" + desetistenka);
            for (int i = 0; i < 10; i++)
            {
                Console.Write(desetistenka.hod() + " ");
            }


            Console.ReadKey();
        }
    }
}
