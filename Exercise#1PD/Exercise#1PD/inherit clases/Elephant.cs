using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1PD.inherit_clases
{
    public class Elephant : Animal
    {
        public Elephant(string name, int age) : base(name, age)
        {
        }


        // Override of the Eat method for an Elephant
        public override void Eat()
        {
            Console.WriteLine($"{name} is using its trunk to eat leaves and grass.");
        }

        // Override of the Sleep method for an Elephant
        public override void Sleep()
        {
            Console.WriteLine($"{name} is sleeping while standing.");
        }





    }
}
