using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Ukoly_2_2
{
    internal class GeneratorSlov
    {
        private string[] privlastky = {" modrý " , " velký ", " hubený ", " nejlepší ", " automatizovaný "};
        private string[] podmety = { " jednorožec ", " programator ", " manažer " , " hroch ", " T-rex "};
        private string[] prisudky = { " spal ", " ležel ", " vařil ", " uklízel ", " derivoval " };
        private string[] prislovce = { " rychle ", " s oblibou ", " hodně ", " málo ", " se zpožděním "};
        private string[] pum = { " pod stromem ", " v lese ", " u babičky ", " v práci ", " na stole "};
        private Random random;

        public GeneratorSlov()
        {
            Array.Sort(podmety);
            foreach (string s in podmety)
            {
                Console.Write("{0} ", s);
            }
            random = new Random();
        }
        public GeneratorSlov(string podmety)
        {
            podmety = podmety;
            random = new Random();
        }
        public  string[] vratPodmety()
        {
            return podmety;
        }
        public string prohozeni(string[] podmety)
        {
            return random.Next(podmety);
        }
        public override string ToString()
        {
            return String.Format("{0} ", podmety[3] , privlastky[4]);

        }

        //private string[] podmet = new string[] { "jednorožec" , "programátor" , "manažer", "hroch" , "T-rex"}; // Využití polí kdž vím že toho bude vždy stějne jinak spíš využívám seznam nebo slovník
        //private string[] prisudek = new string[] { "spal", "letěl", "vařil", "uklízel", "derivoval" };
        //private string[] privlastek = new string[] { "modrý", "vlhký", "hubený", "chytrý", "automatizovaný" };
        //private string[] prislovce = new string[] { "rychle", "s oblibou", "hodně", "málo", "se zpoždením" };
        //private string[] pum = new string[] { "pod stolem", "v lese", "u babičky", "na stole", "v práci" };
        //Random random = new Random();

        //public string GenerujVetu()
        //{
        //    string veta = "";
        //    veta += privlastek[random.Next(0, privlastek.Length)]+ " ";
        //    veta += podmet[random.Next(0, podmet.Length)]+ " ";
        //    veta += prisudek[random.Next(0, prisudek.Length)] + " ";
        //    veta += prislovce[random.Next(0, privlastek.Length)] + " ";
        //    veta += pum[random.Next(0, pum.Length)] + ".";

        //    return veta.Substring(0/*začne od nuly*/,1 /*vezme prvni znak*/).ToUpper()/*zvětší vybraný znak*/ + veta.Substring(1);
        //}
    }
}
