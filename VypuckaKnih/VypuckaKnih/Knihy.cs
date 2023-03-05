using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VypuckaKnih
{
    class Knihy
    {
        public string[] knihovna = {"Hamlet" , "Muži, kteří nenávidí ženy", "Romeo & Julie", "Proměna"};
        public string vyberKnihu;

        public string vypujcKnihu()
        {
            vyberKnihu = Console.ReadLine();
            if (vyberKnihu == knihovna[0] || vyberKnihu == knihovna[1] || vyberKnihu == knihovna[2] || vyberKnihu == knihovna[3])
            {
                Console.WriteLine("Tato kniha je k mání");
                return "Vypůjčil jste si " + vyberKnihu;
            }
            else
            {
                Console.WriteLine("Tato kniha není k zapůjčení");
                Console.WriteLine();
                return null;
            }
            
        }
       

    }
}
