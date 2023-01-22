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
        public float pozice;
        public string soustava;

        public Planeta(string nazev, float pozice, string soustava)
        {
            this.nazev = nazev;
            this.pozice = pozice;
            this.soustava = soustava;
        }
        public string vratNazev()
        {
            return nazev;
        }
        public float vratPozice()
        {
            return pozice;
        }
        public string vratSoustava()
        {
            return soustava;
        }
    }
}
