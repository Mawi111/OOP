using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena
{
    internal class Kostka
    {
        private int pocetSten; // Kdy použít private a public   
        private Random random;

        public Kostka()
        {
            pocetSten = 6;
            random = new Random();
        }
        public Kostka(int aPocetSten)
        {
            pocetSten = aPocetSten;
            random = new Random();
        }
        public int vratPocet()
        {
            return pocetSten;
        }
        public int hod()
        {
            return random.Next(1, pocetSten + 10);
        }

        public override string ToString()
        {
            return String.Format("Kostka s {0} stěnami ", pocetSten);
        }


    }
}
