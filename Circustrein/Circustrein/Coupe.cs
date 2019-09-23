using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    class Coupe
    {
        public List<Animal> AnimalsInCoupe { get; private set; }

        //Animal who eats meat cant be in the same coupe as an animal same size/smaller than him.
        //Coupe maxcapacity = 10, small animal = 1, medium = 3, big = 5.
        //Use up space as much as is possible.
    }
}
