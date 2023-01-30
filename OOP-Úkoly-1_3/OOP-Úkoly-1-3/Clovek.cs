using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Úkoly_1_3
{
    internal class Clovek
    {
        public string jmeno;
        public int vek;

        public Clovek(string jmeno, int vek)
        {
            this.jmeno = jmeno; // Proč je to takhel a co to přesně dělá 
            this.vek = vek;
        }
    }
}
