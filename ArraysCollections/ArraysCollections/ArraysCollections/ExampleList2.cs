using System;
using System.Collections;
namespace ArraysCollections
{
    internal class ExampleList2
    {
        public void Run()
        {
            ArrayList names = new ArrayList();
            Console.WriteLine("Enter 3 Names: ");
            for (int i = 0; i < 3; i++)
            {
                names.Add(Console.ReadLine());

            }
            if (names.Contains("Kamran"))
                Console.WriteLine(" Congrats!, Your name is in the list");
            names.Sort();
            // print sorted using foreach loop
            Console.WriteLine("Print sorted: ");
            foreach(var n in names)

                Console.WriteLine(n);
        }

    }
}
