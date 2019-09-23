using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    class Animal
    {
        //Properties
        public string Diet { get; private set; }

        public string Size { get; private set; }

        public static int n = 1;

        //Constructor
        public Animal(string diet, string size)
        {
            this.Diet = diet;
            this.Size = size;
            n++;
        }

        public override string ToString()
        {
            string s = "Animal: " + n.ToString() + ", " + Diet.ToString() + ", " + Size.ToString();
            return s;
        }
    }
}
