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
            nakladak.Nalozeni();
            //Console.WriteLine("Probíhá druhé naloženi 500 kilogramů...[ENTER]");
            //Console.ReadKey();
            //nakladak.Nalozeni();
            Console.WriteLine("Probíhá vyložení 300 kilogramů...[ENTER]");
            Console.ReadKey();
            nakladak.Vylozeni();


            //Console.WriteLine("Probíhá druhé naloženi 500 kg...[ENTER]");
            //Console.ReadKey();
            //Console.WriteLine("Probíhá první vyloženi 300 kg...[ENTER]");
            //Console.ReadKey();
            //nakladak.Vylozeni();
            //Console.WriteLine("Probíhá druhé vyloženi 1 tuny ...[ENTER]");
            //Console.ReadKey();


            Console.ReadKey();
        }
    }
}
