using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Základy_Opakování_1
{
    class Osoba
    {
        public string jmeno;
        public string prijmeni;
        public byte vek;

        public Osoba()
        {
            jmeno = "Karel";
            prijmeni = "Apolinář";
            vek = 24;
        }
        public string vratJmeno()
        {
            return jmeno;
        }
        public string vratPrijmeni()
        {
            return prijmeni;
        }
        public byte vratVek() 
        {
            return vek;
        }

             
           
    }
}
