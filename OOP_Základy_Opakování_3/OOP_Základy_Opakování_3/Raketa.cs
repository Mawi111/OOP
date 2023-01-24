using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Základy_Opakování_3
{
    internal class Raketa
    {
        public int stavPaliva;
        public string stavLodi1;
        public string stavLodi2;
        public Random Random;

        public Raketa()
        {
            stavPaliva = 30000;
            stavLodi1 = "Dobrý";
            stavLodi2 = "Špatný";

        }
        public int VratStavPaliva()
        {
            return stavPaliva;
        }
        public string VratStavLodi()
        {
            return stavLodi1;
        }
    }
}
