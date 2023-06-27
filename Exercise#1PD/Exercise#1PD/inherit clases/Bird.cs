using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1PD.inherit_clases
{
    public class Bird : Animal
    {
        public Bird(string name, int age) : base(name, age)
        {
        }

        // Override of the Eat method for a Bird
        public override void Eat()
        {
            Console.WriteLine($"{name} is pecking at its food.");
        }

        // Override of the Sleep method for a Bird
        public override void Sleep()
        {
            Console.WriteLine($"{name} is perched on a branch, sleeping.");
        }


    }
}
