using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace pretizeni_metod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vystup;

            vystup = Nasobeni(2, 3, 4);

            Console.WriteLine(vystup);
            Console.WriteLine();    
            Console.ReadKey();
        }

        static double Nasobeni(double a, double b)
        {
            return a * b;
        }
        static double Nasobeni(double a, double b, double c)
        {
            return a * b * c;
        }
    }
}
