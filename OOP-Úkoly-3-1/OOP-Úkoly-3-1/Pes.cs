using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Úkoly_3_1
{
    internal class Pes
    {
        private string jmeno;
        private int vek;

        public Pes(string jmeno)
        {
            this.jmeno = jmeno;
            vek = 1;
        }
        public int Zestarni()
        {
            vek = vek + 1;
            return vek;
        }
        public override string ToString()
        {
            return jmeno + vek;
        }
    }
}
