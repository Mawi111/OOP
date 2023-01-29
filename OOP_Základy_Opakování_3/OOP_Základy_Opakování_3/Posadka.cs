using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Základy_Opakování_3
{
    internal class Posadka
    {
        public int pocetClenu;

        public void Crew()
        {
            Console.WriteLine("Zadejte počet členů posádky: ");
            pocetClenu = int.Parse(Console.ReadLine());
            {
                if (pocetClenu <= 6)
                {
                    Console.WriteLine("V raketě poletí " + pocetClenu);
                    
                }
                else if (pocetClenu > 6)
                {
                    Console.WriteLine("Více než 6 členů raketa neuveze. [Zmáčkni ENTER]");
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }


            }
                
        }
           
    }
}
