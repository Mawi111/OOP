using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Základy_3
{
    class Zdravic
    {
        //public void Pozdrav() 
        //{
        //    Console.WriteLine("Prosím zadejte slovo ");
        //    string slovo = Console.ReadLine();
        //    Console.WriteLine(slovo);

        //}
        public void Interakce()
        {
            Console.WriteLine("Vítejte v kalkulačce");
            string pokracovat = "ano";
            while (pokracovat == "ano")
            {
                Console.WriteLine("Prosím zadejte první číslo: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Prosím zadejte druhé číslo: ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Prosím vyber operaci \n 1 - Součet \n 2 - Rozdíl \n 3 - Součin \n 4 - Podíl");
                Console.WriteLine("Tvůj výběr: ");
                int vysledek = 0;
                int vyber = int.Parse(Console.ReadLine());
                if (vyber <= 0)
                {
                    Console.WriteLine("Tento vyběr provést nelze");
                }
                else if (vyber > 4)
                {
                    Console.WriteLine("Tento vyběr provést nelze");
                }
                else
                {
                    switch (vyber)
                    {

                        case 1:
                            vysledek = a + b;
                            break;
                        case 2:
                            vysledek = a - b;
                            break;
                        case 3:
                            vysledek = a * b;
                            break;
                        case 4:
                            vysledek = a / b;
                            if (a == 0 || b == 0)
                            {
                                Console.WriteLine("Nulou dělit nelze");
                            }
                            else
                            {
                                Console.WriteLine("Tvůj vysledek: {0}", vysledek);
                            }
                            break;
                    }
                    Console.WriteLine("Tvůj vysledek: {0}", vysledek);
                }
                Console.WriteLine("Přejete si zadat další příklad? [ano/ne]");
                pokracovat = Console.ReadLine();
            }
            Console.ReadKey();


        }
        //public void priklad()
        //{
        //    int a = 1;
        //    int b = 2;
        //    console.writeline(a + b);
        //}

    }
}
