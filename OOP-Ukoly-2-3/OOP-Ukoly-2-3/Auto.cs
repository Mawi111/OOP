using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Ukoly_2_3
{
    internal class Auto
    {
        private string SPZ;
        private string barva;

        public Auto()
        {
            SPZ = "123ABC";
            barva = "žluté";
        }
        public string Zaparkuj()
        {
            return SPZ + " " + barva;
        }
        
    }
}
