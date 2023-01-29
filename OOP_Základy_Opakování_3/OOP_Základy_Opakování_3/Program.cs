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
            Planeta Proxima = new Planeta("Proxima Centauri b", 4.2F, "Kentaur", 3);
            Planeta Luyten = new Planeta("Luyten b", 12.36F, "Malý pes", 3);
            Planeta Wolf = new Planeta("Wolf 1061c", 13.8F, "Hadonoš", 1);
            Zeme zeme = new Zeme();
            Raketa raketa = new Raketa();
            Posadka posadka = new Posadka();

            Console.WriteLine("==============================");
            Console.WriteLine("Vítám tě v jednoduché vesmírné hře. [Zmáčkni ENTER]");
            Console.ReadKey();
            Console.WriteLine("Cílem hry je dostat co možná v největším počtu šesti členou posádku na tebou vybranouj planetu. \nAle POZOR! Každá cesta má určitou míru nebezpečí! [Zmáčkni ENTER]");
            Console.ReadKey();
            //Console.WriteLine("==============================");
            //posadka.Crew();

            Console.WriteLine("==============================");

            Console.WriteLine("Stav paliva: " + raketa.stavPaliva + " hl");
            Console.WriteLine("Aktuální stav rakety: "+raketa.stavLodi1);

            Console.WriteLine("[Zmáčkni ENTER]");
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
