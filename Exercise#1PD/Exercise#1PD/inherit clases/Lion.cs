using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1PD.inherit_clases
{
    public class Lion : Animal
    {
        public Lion(string name, int age) : base(name, age)
        {
        }

        public override void Eat()
        {
            Console.WriteLine($"The lion is devouring its prey");
        }

        public override void Sleep()
        {
            Console.WriteLine($"The lion is sleeping soundly");
        }
    }
}
