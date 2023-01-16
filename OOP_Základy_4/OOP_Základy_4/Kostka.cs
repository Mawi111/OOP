﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Základy_4
{
    class Kostka
    {
        private Random random;
        private int pocetSten;

        public Kostka()
        {
            pocetSten = 6;
            random = new Random();
        }

        public Kostka(int pocetSten)
        {
            this.pocetSten = pocetSten;
            random = new Random();
        }
        public int VratPocetSten()
        {
            return pocetSten;
        }
        public int Hod() 
        {
            return random.Next(1, pocetSten + 1);
        }
        public override string ToString()
        {
            return String.Format("Kostka se {0} stěnami", pocetSten);
        }
    }
}
