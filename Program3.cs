using System;

namespace InterfaceExample
{
    interface IAnimal
    {
        void Eat();
    }

    interface IPet
    {
        void Play();
    }

    class Dog : IAnimal, IPet
    {
        public void Eat()
        {
            Console.WriteLine("Dog is eating.");
        }

        public void Play()
        {
            Console.WriteLine("Dog is playing.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Play();

            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
