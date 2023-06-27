using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1PD
{// Abstract class representing an Animal
    public abstract class Animal
    {
        protected string name; // Protected field for storing the animal's name
        protected int age; // Protected field for storing the animal's age

        public Animal (string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Property for accessing and modifying the animal's name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Property for accessing and modifying the animal's age
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("age", "Age cannot be negative");
                }
                age = value;
            }
        }


        public virtual void Eat()
        {
            Console.WriteLine($"{Name} is eating");
        }

        public virtual void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping");
        }



    }
}
