using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorVet
{
    class Program
    {

        /*
         *  _____ _______         _                      _              
         * |_   _|__   __|       | |                    | |             
         *   | |    | |_ __   ___| |___      _____  _ __| | __  ___ ____
         *   | |    | | '_ \ / _ \ __\ \ /\ / / _ \| '__| |/ / / __|_  /
         *  _| |_   | | | | |  __/ |_ \ V  V / (_) | |  |   < | (__ / / 
         * |_____|  |_|_| |_|\___|\__| \_/\_/ \___/|_|  |_|\_(_)___/___|
         * 
         * IT ZPRAVODAJSTVÍ  <>  PROGRAMOVÁNÍ  <>  HW A SW  <>  KOMUNITA
         * 
         * Tento zdrojový kód je součástí výukových seriálů na 
         * IT sociální síti WWW.ITNETWORK.CZ	
         *	
         * Kód spadá pod licenci prémiového obsahu a vznikl díky podpoře
         * našich členů. Je určen pouze pro osobní užití a nesmí být šířen.
         *
         */

        static void Main(string[] args)
        {
            GeneratorVet generator = new GeneratorVet();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(generator.Generuj());
            }
            Console.ReadKey();
        }
    }
}
