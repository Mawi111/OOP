using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Základy_Opakování_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Osoba osoba = new Osoba();
            //Console.Write(osoba.vratJmeno()+ "-");
            //Console.Write(osoba.vratPrijmeni()+ "-");
            //Console.Write(osoba.vratVek());

            Auto auto = new Auto();
            Console.Write("Barva auta: "+auto.vratBarvu()+"\n");
            Console.Write("SPZ: "+auto.vratSpz()+"\n");
            Console.Write("Najeto: "+auto.vratNajeto()+" km");


            Console.ReadKey();
        }
    }
}
