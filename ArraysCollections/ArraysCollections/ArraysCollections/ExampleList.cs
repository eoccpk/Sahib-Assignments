using System;
using System.Collections;
namespace ArraysCollections
{
    internal class ExampleList
    {
        public void Run()
        {
            ArrayList marks = new ArrayList();
            Console.WriteLine("Adding some Numbers:");
            marks.Add(56);
            marks.Add(84);
            //add more 
            Console.WriteLine("Enter 3 more numbers: ");
            for(int i=0;i<3;i++)
            {
                marks.Add(Convert.ToInt32(Console.ReadLine()));

            }
            marks.Sort();
            // print sorted
            Console.WriteLine("Print sorted: ");
            for(int i=0; i < marks.Count; i++)
                Console.WriteLine(marks[i]);
        }
    }
}
