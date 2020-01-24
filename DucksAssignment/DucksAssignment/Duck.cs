using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DucksAssignment
{
    public abstract class Duck
    {
        public float weight { get; set; }
        public int numberOfWings { get; set; }

        public Duck(float weight, int numberOfWings)
        {
            this.weight = weight;
            this.numberOfWings = numberOfWings;
        }
            
        //public virtual void ShowDetails()
        //{

        //}
    }
}
