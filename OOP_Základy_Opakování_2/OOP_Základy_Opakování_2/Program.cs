using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Základy_Opakování_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();
            //Console.WriteLine("Prosím zadej jméno první osoby: ");
            //string osoba1 = Console.ReadLine();
            //Console.WriteLine("Prosím zadej jméno druhé osoby: ");
            //string osoba2 = Console.ReadLine();
            //Console.WriteLine("Prosím zadej jméno třetí osoby: ");
            //string osoba3 = Console.ReadLine();
            //Console.WriteLine("=======================================");
            //person.Jmeno(osoba1);
            //person.Jmeno(osoba2);
            //person.Jmeno(osoba3);


            //Console.ReadKey();

            int total = 3;
            Person[] persons = new Person[total];

            for (int i = 0; i < total; i++)
            {
                persons[i] = new Person()
                {
                    Name = Console.ReadLine()
                };
            }

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine(persons[i].ToString());
            }

            Console.ReadLine();
        }
    }
}
