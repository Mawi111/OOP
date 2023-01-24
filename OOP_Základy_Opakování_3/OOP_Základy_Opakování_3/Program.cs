using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Základy_Opakování_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Planeta Proxima = new Planeta("Proxima Centauri b", 4.2F, "Kentaur");
            Planeta Luyten = new Planeta("Luyten b", 12.36F, "Malý pes");
            Planeta Wolf = new Planeta("Wolf 1061c", 13.8F, "Hadonoš");
            Zeme zeme = new Zeme();
            Raketa raketa = new Raketa();

            Console.WriteLine("==============================");

            Console.WriteLine("Stav paliva: " + raketa.stavPaliva + " hl");
            Console.WriteLine("Aktuální stav rakety: "+raketa.stavLodi1);

            Console.WriteLine("Zmáčkni enter");
            string pokracovat = Console.ReadKey().Key.ToString();
            if (pokracovat == "Enter")
            {
                Console.WriteLine("==============================");

                Console.WriteLine("Výchozí bod: " + zeme.vratVychoziPlaneta());
                Console.WriteLine("Soustava: " + zeme.vratVychoziSoustavu());
                Console.WriteLine("==============================");
                Console.WriteLine("Planety: \n Proxima Centauri b \n Luyten b \n Wolf 1061c \n\nVyberte cílovou planetu:");
                string cil = Console.ReadLine();
                Console.WriteLine("==============================");
                if (cil == "Proxima Centauri b")
                {
                    Console.WriteLine("Cílová planeta: " + Proxima.vratNazev());
                    Console.WriteLine("Vzdálenost od Země: " + Proxima.vratPozice() + " světelných let");
                    Console.WriteLine("Soustava: " + Proxima.vratSoustava());
                }
                else if (cil == "Luyten b")
                {
                    Console.WriteLine("Cílová planeta: " + Luyten.vratNazev());
                    Console.WriteLine("Vzdálenost od Země: " + Luyten.vratPozice() + " světelných let");
                    Console.WriteLine("Soustava: " + Luyten.vratSoustava());
                }
                else if (cil == "Wolf 1061c")
                {
                    Console.WriteLine("Cílová planeta: " + Wolf.vratNazev());
                    Console.WriteLine("Vzdálenost od Země: " + Wolf.vratPozice() + " světelných let");
                    Console.WriteLine("Soustava: " + Wolf.vratSoustava());
                }
                else
                {
                    Console.WriteLine("Planeta neni v 'databázi'.");
                }
            }
            else
                Console.WriteLine("Nezmáčknul jsi enter");
            
            Console.ReadKey();
        }
    }
}
