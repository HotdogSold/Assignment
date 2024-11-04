using System;
using System.Collections;

namespace CollectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an ArrayList
            ArrayList arrayList = new ArrayList();

            // Add elements to the ArrayList
            arrayList.Add(1);
            arrayList.Add("Hello");
            arrayList.Add(3.14);

            // Access elements in the ArrayList
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}

