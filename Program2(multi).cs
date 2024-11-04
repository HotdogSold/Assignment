using System;

namespace InheritanceExample
{
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Barking...");
        }
    }

    class Puppy : Dog
    {
        public void Weep()
        {
            Console.WriteLine("Weeping...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Puppy puppy = new Puppy();
            puppy.Eat();  // Inherited from Animal
            puppy.Bark(); // Inherited from Dog
            puppy.Weep(); // Defined in Puppy

            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
