using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP_Úkoly_3_3
{
    internal class Rodokmen
    {
        private Osoba osobaVypisu;
        public Rodokmen(Osoba osobaVypisu)
        {
            this.osobaVypisu = osobaVypisu;

        }
        private void vratRodokmen(Osoba osoba)
        {
            if(osoba != null)
            {
                Console.WriteLine(osoba);
                vratRodokmen(osoba.matka);
                vratRodokmen(osoba.otec);
            }
        }
        public void Vypis()
        {
            Console.WriteLine("Rodokmen pro osobu {0} ", osobaVypisu);
            vratRodokmen(osobaVypisu);
        }
       



    }
}
