using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Ukoly_2_3
{
    internal class Garaz
    {
        private int cisloGaraze;
        private string zaparkovaneAuto;

        public Garaz()
        {
            cisloGaraze = 789;
            Auto auto = new Auto();
            zaparkovaneAuto = auto.Zaparkuj();
        }
        public override string ToString()
        {
            return String.Format("Auto " +zaparkovaneAuto + " je zaparkováno v garáži číslo " + cisloGaraze); 
        }



    }
}
