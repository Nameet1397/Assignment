using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DucksAssignment
{
    enum TypeOfDuck
    {
        Rubber, Mallard, Redhead
    };

    class Program
    {
        public static Duck createDuck()
        {
            Console.Write("Enter Weight : ");
            float weight = float.Parse(Console.ReadLine());
            Console.Write("Enter Number of Wings : ");
            int wings = int.Parse(Console.ReadLine());
            Console.Write("Enter Type of Duck : 1. Rubber 2. Mallard 3.Redhead");
            int input = int.Parse(Console.ReadLine());
            switch(input)
            {
                case 1:
                    {
                        return new Rubber(weight, wings, TypeOfDuck.Rubber);
                    }
                case 2:
                    {
                        return new Mallard(weight, wings, TypeOfDuck.Mallard);
                    }
                case 3:
                    {
                        return new Redhead(weight, wings, TypeOfDuck.Redhead);
                    }
                default:
                    {
                        Console.WriteLine("Invalid Entry");
                        Console.ReadLine();
                        createDuck();
                        break;
                    }
            }
            return null;
        }
        static void Main(string[] args)
        {
            Duck d = createDuck();
            d.ShowDetails();

            Console.ReadLine();

        }
    }
}
