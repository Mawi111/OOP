using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Úkoly_3_2
{
    internal class Lokace
    {
        private string misto;
        
        public Lokace(string misto)
        {
            this.misto = misto;
        }
        public override string ToString()
        {
            return misto;
        }

    }
}
