using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Úkoly_2_1_2
{
    internal class Clovek
    {
        private string jmeno;
        private int unava;


        public Clovek()
        {
            jmeno = "Karel Novotný";
        }
        public override string ToString()
        {
            return String.Format("Jsem " + jmeno + " (25).\nMoje aktuální úvana je " + unava);
        }
        public int Beh()
        {
            unava = unava + 10;
            if (unava == 20)
            {
                Console.WriteLine("Jsem příliš unavený");
                return unava + 0;
            }
            else
                return unava;
        }
        public int Odpocinek()
        {
            unava = unava - 10;
            return unava;
        }
    }
}
