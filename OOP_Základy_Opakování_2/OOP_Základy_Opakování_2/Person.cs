using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Základy_Opakování_2
{
    class Person
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return "Hello! My name is " + Name;
        }
    }
}
