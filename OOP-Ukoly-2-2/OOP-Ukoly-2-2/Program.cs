using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Ukoly_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            GeneratorSlov generatorSlov = new GeneratorSlov();

            Console.WriteLine(generatorSlov.ToString());

            Console.ReadKey();
        }
    }
}
