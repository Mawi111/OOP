using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Základy_Opakování_1
{
    class Auto
    {
        public string barva;
        public int spz; 
        public int najeto; 

        public Auto()
        {
           barva = "černá";
           spz = 1248109;
           najeto = 60000;
        }
        public string vratBarvu() 
        {
            return barva;
        }
        public int vratSpz()
        {
            return spz;
        }
        public int vratNajeto()
        {
            return najeto;
        }


    }
}
