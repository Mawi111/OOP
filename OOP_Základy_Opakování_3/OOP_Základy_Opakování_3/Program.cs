using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Základy_Opakování_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Planeta planeta = new Planeta();
            Zeme zeme = new Zeme();
            Console.WriteLine("Výchozí bod: "+zeme.vratVychoziPlaneta());
            Console.WriteLine("Soustava: "+zeme.vratVychoziSoustavu());
            Console.WriteLine("==============================");
            Console.WriteLine("Cílová planeta: "+planeta.vratNazev());
            Console.WriteLine("Vzdálenost od Země: "+planeta.vratPozice()+" světelných let");
            Console.WriteLine("Soustava: "+planeta.vratSoustava());


            Console.ReadKey();
        }
    }
}
