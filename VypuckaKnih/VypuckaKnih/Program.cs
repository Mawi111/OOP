using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VypuckaKnih
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Knihy knihy = new Knihy();
            Osoba osoba = new Osoba();
            Console.WriteLine("Knihovna nabízí následující knihy: \n {0}\n {1}\n {2}\n {3}\nKterou si chcete vypůjčit?", knihy.knihovna);
            Console.WriteLine("Vypůjčit si chce: \n {0}\n {1}\n {2}\nKdo si vypůjčí kterou knihu?", osoba.osoby);
            
            Console.WriteLine(knihy.vypujcKnihu());
            Console.ReadKey();
            
            
            //string[] books = {"Hamlet", "Romeo & Julie", "Muži, kteří nenávidí ženy", "Proměna" };
            //string vyberKnihy = Console.ReadLine();
            //if (vyberKnihy == books[0] || vyberKnihy == books[1] || vyberKnihy == books[2] || vyberKnihy == books[3])
            //{
            //    Console.WriteLine("Tato kniha je v knihovně");
            //    Console.WriteLine("Vypůjčil jste si {0}", vyberKnihy);
            //}
            //else
            //{
            //    Console.WriteLine("Tato kniha není v knihovně");
            //}
            
            //Console.ReadKey();
        }
    }
}
