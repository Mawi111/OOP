using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Základy_Opakování_3
{
    internal class Zeme
    {
        public string vychoziPlaneta;
        public string vychoziSoustava;
        public long pozice;
        
        public Zeme()
        {
            vychoziPlaneta = "Země";
            vychoziSoustava = "Místní hvězdokupa";
        }
        public string vratVychoziPlaneta()
        {
            return vychoziPlaneta;
        }
        public string vratVychoziSoustavu()
        {
            return vychoziSoustava;
        }
    }
}
