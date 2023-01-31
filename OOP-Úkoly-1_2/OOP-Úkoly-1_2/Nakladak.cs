using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Úkoly_1_2
{
    internal class Nakladak
    {
        public int naklad;
        public int nostnost;
        public int vyklad;

        public Nakladak()
        {
            nostnost = 3000;
            naklad = 0;
        }
        public int Nalozeni()
        {
            Console.WriteLine("Probíhá první naloženi 10 tun...[ENTER]");
            Console.ReadKey();
            naklad = 10000;
            if (naklad > nostnost)
            {
               Console.WriteLine("Nelze naložit. Maximální nostnost je 3 tuny");
               naklad = naklad * 0;
            }
            naklad = 500;
            Console.WriteLine("Probíhá naložení 500 kilogramů...[ENTER]");
            Console.ReadKey();
               
            return naklad;
        }
        public int Vylozeni()
        {
            naklad = naklad - 300;
            Console.WriteLine("Probíhá vyložení 300 kilogramů...[ENTER]");
            Console.ReadKey();
            Console.WriteLine("Probíhá vyložení 1 tuny...[ENTER]");
            Console.ReadKey();
            vyklad = 10000;
            if (vyklad > naklad)
            {
                Console.WriteLine("Nelze vyložit 1 tunu");
            }
            Console.WriteLine("Aktuální náklad "+naklad+" kilogramů");
            return naklad;
        }
    }
}
