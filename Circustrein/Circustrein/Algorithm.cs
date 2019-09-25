using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Circustrein.Common;

namespace Circustrein
{
    class Algorithm
    {
        public List<Coupe> SortAnimalsIntoCoupes(List<Animal> animals)
        {
            //NotDone
            Train t = new Train();
            Coupe c = new Coupe();
            t.coupes.Add(c);
            foreach (var animal in animals)
            {

                //WiP
                foreach (var coupe in t.coupes.ToList())
                {
                    if (CanAnimalBeAdded(animal, c))
                    {
                        c.AnimalsInCoupe.Add(animal);
                    }
                    else
                    {
                        Coupe newc = new Coupe();
                        t.coupes.Add(newc);
                        newc.AnimalsInCoupe.Add(animal);
                    }
                }
            }
            return t.coupes;
        }

        public bool CanAnimalBeAdded(Animal a, Coupe c)
        {
            //NotDone
            if (CheckCapacity(a, c) && CheckDietCompatibility(a, c))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckCapacity(Animal a, Coupe c)
        {
            //NotDone
            int total = 0;
            foreach (var animal in c.AnimalsInCoupe)
            {
                total = total + (int)animal.Size;
            }
            if ((int)a.Size + total > 10)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool CheckDietCompatibility(Animal a, Coupe c)
        {
            //WiP
            foreach (var animal in c.AnimalsInCoupe)
            {
                if (a.Diet == AnimalDiet.Carnivore)
                {
                    //Check for size
                    if (CheckSizeCompatibility(a, animal))
                    {
                        //Coupe newcoupe = new Coupe();
                        //newcoupe.AnimalsInCoupe.Add(animal);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }
            //Returns true if list is empty.
            return true;
        }

        public bool CheckSizeCompatibility(Animal a, Animal b)
        {
            //NotDone
            if ((int)a.Size < (int)b.Size)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
