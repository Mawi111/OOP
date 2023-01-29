using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hra
{
    internal class Kostka
    {
        public Random random;
        public int pocetSten;

        public Kostka()
        {
            pocetSten = 6;
            random = new Random();
        }

        public int vratPocetSten()
        {
            return pocetSten;
        }
        public int hod()
        {
            return random.Next(1, pocetSten + 1);
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
