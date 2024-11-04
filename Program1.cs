using System;

namespace ConstructorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.DisplayInfo();

            Person person2 = new Person("Alice", 30);
            person2.DisplayInfo();

            // Keep the console window open
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person()
        {
            Name = "Unknown";
            Age = 0;
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}
