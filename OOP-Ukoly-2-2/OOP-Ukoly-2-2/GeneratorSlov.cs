using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Ukoly_2_2
{
    internal class GeneratorSlov
    {
        private string podmety; 
        private string prisudky;
        private string privlastky;
        private string prislovce;
        private string pum;
        private Random random;

        public GeneratorSlov()
        {
            podmety = " jednorožec";
            prisudky = " spal";
            privlastky = " modrý";
            prislovce = " rychle";
            pum = " pod stolem";
            random = new Random();
        }
        public GeneratorSlov(string apodmety, string aprisudky, string aprivlastky, string aprislovce, string apum)
        {
            podmety = apodmety;
            prisudky = aprisudky;
            privlastky = aprivlastky;
            prislovce = aprislovce;
            pum = apum;
            random = new Random();
        }

        public string vratSlova()
        {
            return privlastky + podmety + prislovce + prisudky + pum; 
        }
        public string prohozeni()
        {
            return random.Next(1, podmety + 1);
        }
    }
}
