using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Základy_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zdravic zdravic = new Zdravic();
            //zdravic.text = "Ahoj uživateli";
            //zdravic.Pozdrav("Karel");
            //zdravic.Pozdrav("Petr");
            //Console.ReadKey();

            Kostka sestistena = new Kostka();
            Kostka desetistena = new Kostka(10);
            
            Console.WriteLine(sestistena);
            for (int i = 0; i < 6; i++)
                Console.Write(sestistena.Hod() + " ");

            Console.WriteLine("\n\n" + desetistena);
            for (int i = 0; i < 10; i++)
                Console.Write(desetistena.Hod() + " ");

            Console.ReadKey();
        }
    }
}
