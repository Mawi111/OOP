using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaklady_OPP_1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Zdravic kalkulacka = new Zdravic();
            //zdravic.text = "Ahoj uživateli";
            //zdravic.Pozdrav("Karl");
            //zdravic.Pozdrav("Petr");
            //zdravic.text= "Vitáme tě tu programátore";
            //zdravic.Pozdrav("Richard");

            Kalkulacka kalkulacka = new Kalkulacka();
            kalkulacka.Napleneni();
            kalkulacka.Soucet();
            Console.ReadKey();
            
        }
    }
}
