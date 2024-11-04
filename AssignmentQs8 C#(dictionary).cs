using System;
using System.Collections.Generic;

namespace CollectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Dictionary
            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            // Add elements to the Dictionary
            dictionary.Add(1, "One");
            dictionary.Add(2, "Two");
            dictionary.Add(3, "Three");

            // Access elements in the Dictionary
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
