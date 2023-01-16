using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Základy_Opakování_3
{
    internal class Planeta
    {
        public string nazev;
        public long pozice;
        public string soustava;
        public string vychoziPlaneta;

        public Planeta()
        {
            nazev = "Tiviera";
            pozice = 70000000000;
            soustava = "Erecus";
        }
        public string vratNazev()
        {
            return nazev;
        }
        public long vratPozice()
        {
            return pozice;
        }
        public string vratSoustava()
        {
            return soustava;
        }
    }
}
