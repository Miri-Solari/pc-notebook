using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_1
{
    internal class Class1
    {
        internal int id { get; private set; }
        internal string name { get; private set; }
        internal string description { get; private set; }

        public string NamaeWa = "default";

        internal Class1(string name, int id, string discription)
        {
            this.name = name;
            this.id = id;
            this.description = discription;
        }

        public void OLEG(int x)
        {
            Console.WriteLine(x);
        }
    }
}
