using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Úkoly_1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clovek clovek = new Clovek("Karel Novák", 33); // Proč je to takhel a co to přesně dělá 
            Clovek kamarad = new Clovek("Cyril Nový", 27);
            
            
            
           
            Console.WriteLine("Ahoj já jsem "+clovek.jmeno+" je mi "+clovek.vek+" let a můj kamarád je "+kamarad.jmeno);
            Console.WriteLine("Ahoj já jsem " + kamarad.jmeno + " je mi " + kamarad.vek + " let a můj kamarád je " + clovek.jmeno);

            Console.ReadKey();
        }
    }
}
