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
    }
}
