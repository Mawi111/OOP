using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Úkoly_3_1
{
    internal class Osoba
    {
        private string jmenoOsoby;
        public Pes pes;   

        public Osoba(string jmenoOsoby)
        {
            this.jmenoOsoby = jmenoOsoby;
        }
        public override string ToString()
        {
            return jmenoOsoby;
        }
    }
}
