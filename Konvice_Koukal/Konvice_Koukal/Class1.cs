using System;
using System.Collections.Generic;
using System.Text;

namespace Konvice_Koukal
{
    class Class1
    {
        float  max_l;
        float  aktualni_pocet;
        float  promena;

        public Class1(int max_objem) 
        {
            if (max_l > 0 && max_l < 2)
                max_l = max_objem;
            else 
            {
                max_l = 5;
                Console.WriteLine("Nestandartní maximální objem. Nastaveno je " + max_l + ".");
            }

            promena = 0;


        }

        public void Prilevani(float prilevani) 
        {
            if (prilevani < 1)
                Console.WriteLine("Počet l v konvici se nezměnil");
            else 
            {
                if (prilevani + promena > max_l)
                    Console.WriteLine("Počet zadaných l není zadatelný \n V konvici je" + promena + " l.");
                else 
                {
                    promena += prilevani;
                    Console.WriteLine("Bylo přilito" + prilevani + " a nyný v ní je" + promena+ "l instance");


                }


                    
            }
        }

        public void Odlevani(float odlev) 
        {
            if (odlev < 0.01)
                Console.WriteLine("Počet litrů je stejný");
            else 
            {
                if (promena = odlev <= 0)
                    Console.WriteLine("Odlev není možný \n V konvici není dostatek litrů");
                else 
                {
                    promena -= odlev;
                    Console.WriteLine("Z konve bylo vylito" + odlev +" a nyní je" + promena + "l.");
                }
            }
        }
        public void vyvrcholení() 
        {
            promena = 0;
            Console.WriteLine("Zde je konec, už nevím jak dál :/");
        }

        

    }
}
