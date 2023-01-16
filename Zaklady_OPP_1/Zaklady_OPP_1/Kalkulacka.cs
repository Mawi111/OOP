using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaklady_OPP_1
{
    class Kalkulacka
    {
        float a;
        float b;
        public void Napleneni()
        {
           Console.WriteLine("Prosím vyplň první číslo");
           float a = float.Parse(Console.ReadLine());
           Console.WriteLine("Prosím vyplň druhé číslo");
           float b = float.Parse(Console.ReadLine());
            
        }
        public void Soucet()
        {
            float c = a + b;
            Console.WriteLine(c);
        }
    }
}
