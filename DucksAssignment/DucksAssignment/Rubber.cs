using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DucksAssignment
{
    class Rubber : Duck
    {
        public TypeOfDuck tod;
        public Rubber(float weight, int numberOfWings, TypeOfDuck tod) : base(weight, numberOfWings)
        {
            this.tod = tod;
        }
        public override void ShowDetails()
        {
            Console.WriteLine(tod + ": don’t fly and squeak");
        }
    }
}
