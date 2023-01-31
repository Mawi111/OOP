using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Nakladak_Interaktivni
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
