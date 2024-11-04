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

    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Eat();  // Inherited from Animal
            dog.Bark(); // Defined in Dog

            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}

