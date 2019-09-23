using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Circustrein.Common;

namespace Circustrein
{
    class Animal
    {
        //Properties
        private AnimalDiet Diet { get; set; }

        private AnimalSize Size { get; set; }

        private int n;

        private static int nCounter = 1;

        //Constructor
        public Animal(AnimalDiet diet, AnimalSize size)
        {
            this.Diet = diet;
            this.Size = size;
            n = nCounter;
            nCounter++;
        }

        public override string ToString()
        {
            string s = "Animal: " + n.ToString() + ", " + Diet.ToString() + ", " + Size.ToString();
            return s;
        }
    }
}
