// See https://aka.ms/new-console-template for more information


using Exercise_1PD;
using Exercise_1PD.inherit_clases;

// Create instances of Lion, Elephant, and Bird
Lion lion = new Lion("Simba", 5);
Elephant elephant = new Elephant("Dumbo", 10);
Bird bird = new Bird("Tweety", 2);

// Create a list of Animal
List<Animal> animals = new List<Animal>();
animals.Add(lion);
animals.Add(elephant);
animals.Add(bird);


// Iterate over the list of animals and call the Eat() and Sleep() methods
foreach (Animal animal in animals)
{
    Console.WriteLine($"Name: {animal.Name}, Age: {animal.Age}");
    animal.Eat();
    animal.Sleep();
    Console.WriteLine();
}

Console.WriteLine("Ready!");
