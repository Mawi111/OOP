using System;

namespace Konvice_Koukal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Class1 konvice1 = new Class1(2);
            Class1 konvice2 = new Class1(5);

            float prilevani_odlevani;

            do
            {
                Console.WriteLine("Změna v l");
                prilevani_odlevani = float.Parse(Console.ReadLine());
                if (prilevani_odlevani > 0)
                    konvice1.Prilevani(prilevani_odlevani);
                if (prilevani_odlevani < 0)
                    konvice1.Odlevani(prilevani_odlevani);



            } while (prilevani_odlevani != 0 && prilevani_odlevani != 111);
            konvice1.konec();
            
            if (prilevani_odlevani == 111) 
            {
                do
                {
                    Console.WriteLine("Zadej změnu v l");
                    prilevani_odlevani = float.Parse(Console.ReadLine());
                    if (prilevani_odlevani > 0)
                        konvice2.Prilevani(prilevani_odlevani);
                    if (prilevani_odlevani < 0)
                        konvice2.Odlevani(prilevani_odlevani);

                }
                while (prilevani_odlevani != 0);
            }


            
                     
            
            
                

            
                                       
            


        }
    }
}
