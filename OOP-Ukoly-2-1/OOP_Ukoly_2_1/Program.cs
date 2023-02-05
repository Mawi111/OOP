using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Ukoly_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clovek clovek = new Clovek();
            Console.WriteLine(clovek.ToString());
            Console.WriteLine("\n Uběhnul jsem : " + clovek.Beh() + " km.\n Mám uběhnout dalších 10 km? Nebo si můžu odpočinou? [B/O] " );
            string odpoved1 = Console.ReadLine();
            if (odpoved1 == "B")
            {
                Console.WriteLine("Uběhnul jsem " + clovek.Beh()+ " km" + "\n Mám uběhnout dalších 10 km? Nebo si můžu odpočinout? [B/O] ");
                string odpoved2 = Console.ReadLine();
                if (odpoved2 == "B")
                {
                    Console.WriteLine("Nemám dost síly");

                }
                else
                {
                    Console.WriteLine("Odpočinul jsem si. Nyní mám únavu na "+clovek.Odpocinek() /*+ ". Moje únava je " + clovek.unava*/);
                    
                }
            }
            else if (odpoved1 == "O")  
            {
                Console.WriteLine("Odpočinul jsem si. Nyní mám únavu na " + clovek.Odpocinek());
                Console.WriteLine("Mám uběhnout dalších 10 km? [A/N] ");
                string odpoved3 = Console.ReadLine();
                if (odpoved3 == "A")
                {

                    Console.WriteLine("Uběhnul jsem dalších "+ clovek.Beh() +" km");

                }
                else
                {
                    Console.WriteLine("Nebudu běhat dál");
                }
            }
            Console.ReadKey();
        }
    }
}
