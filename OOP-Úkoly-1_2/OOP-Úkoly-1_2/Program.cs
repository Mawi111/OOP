using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Úkoly_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nakladak nakladak = new Nakladak();

            Console.WriteLine("Probíhá první naloženi 10 tun...[ENTER]");
            Console.ReadKey();
            nakladak.Nalozeni1();
            Console.WriteLine("Probíhá druhé naloženi 500 kg...[ENTER]");
            Console.ReadKey();
            nakladak.Nalozeni2();
            Console.WriteLine("Probíhá první vyloženi 300 kg...[ENTER]");
            Console.ReadKey();
            nakladak.Vylozeni1();
            Console.WriteLine("Probíhá druhé vyloženi 1 tuny ...[ENTER]");
            Console.ReadKey();
            nakladak.Vylozeni2();

            Console.ReadKey();
        }
    }
}
