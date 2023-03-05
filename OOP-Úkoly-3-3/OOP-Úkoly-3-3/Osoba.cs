using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Úkoly_3_3
{
    internal class Osoba
    {
        public string jmeno;
        public Osoba otec;
        public Osoba matka;

        public Osoba(string jmeno, Osoba otec, Osoba matka)
        {
            this.jmeno = jmeno;
            this.matka = matka;
            this.otec = otec;
        }
        public override string ToString()
        {
            return jmeno;
        }
    }
}
