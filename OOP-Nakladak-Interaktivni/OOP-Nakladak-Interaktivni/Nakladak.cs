using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Nakladak_Interaktivni
{
    internal class Nakladak
    {
        public int naklad;
        private int misto;
        public int nostnost;
        public int vyklad;

        public Nakladak()
        {
            nostnost = 3000;
        }
        public int Nalozeni()
        {
            if (naklad > nostnost)
            {
                Console.WriteLine("Nelze naložit. Maximální nostnost je 3 tuny...[ENTER]");
                Console.ReadKey();
                Environment.Exit(3);
            }
            else
            {
                misto = nostnost - naklad;
                Console.WriteLine("Probíhá naložení " +  naklad + " kilogramů. Aktuální místo je " + misto + " kilogramů...[ENTER]");
            }
            Console.ReadKey();
            return naklad;
            
        }
        public int Vylozeni()
        {
            Console.WriteLine("Kolik chceš vyložit? (kg)");
            vyklad = int.Parse(Console.ReadLine());
            if (vyklad > naklad) 
            {
                Console.WriteLine("Nelze vyložit...");
                Console.ReadKey();
                Environment.Exit(3);

            }
            else
            {
                naklad = naklad - vyklad;
                misto = misto - vyklad;
                Console.WriteLine("Probíhá vyložení " + vyklad + " kg aktuálně je naloženo " + naklad + " kg. Misto na korbě je " + misto + "...[ENTER]");
                
            }
            return naklad;
        }
    }
}
