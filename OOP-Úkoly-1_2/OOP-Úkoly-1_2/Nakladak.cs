using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Úkoly_1_2
{
    internal class Nakladak
    {
        public int naklad;
        public int nostnost;
        public int misto;

        public Nakladak()
        {
            nostnost = 3000;
            naklad = 0;
        }
        public int Nalozeni()
        {
            naklad = 10000;
            if (naklad > nostnost)
            {
               Console.WriteLine("Nelze naložit. Maximální nostnost je 3 tuny");
               naklad = naklad * 0;
            }
            naklad = 500;
            Console.WriteLine("Probíhá naložení 500 kilogramů...[ENTER]");
            Console.ReadKey();
               
            return naklad;
        }
        public int Vylozeni()
        {
            naklad = naklad - 300;
            misto = nostnost - naklad;
            Console.WriteLine("Aktuální náklad "+naklad+ " zbývající místo je "+misto);
            
            return naklad;
        }
        //public int Vylozeni2()//Musím se zeptat učitele
        //{
        //    misto = naklad;
        //    naklad = naklad - 1000;
        //    if (naklad < misto)
        //    {
        //        Console.WriteLine("Nemůžu vyložit 1 tunu, když mám na korbě "+misto);
        //    }
        //    return naklad;
        //}


    }
}
