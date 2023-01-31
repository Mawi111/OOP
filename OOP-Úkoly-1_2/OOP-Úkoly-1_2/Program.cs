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
            nakladak.Nalozeni();
            nakladak.Vylozeni();
            Console.ReadKey();
        }
    }
}
