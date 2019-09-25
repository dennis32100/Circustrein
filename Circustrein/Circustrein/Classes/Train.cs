using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    class Train
    {
        public List<Coupe> coupes { get; set; }

        public Train()
        {
            List<Coupe> coupes = new List<Coupe>();
            this.coupes = coupes;
        }

        //public void AddCoupe(Coupe c)
        //{
        //    coupes.Add(c);
        //}

        //public override string ToString()
        //{
        //    foreach (var coupe in coupes)
        //    {
        //        coupe.AnimalsInCoupe.ToString()
        //    }
        //    return;
        //}
    }
}
