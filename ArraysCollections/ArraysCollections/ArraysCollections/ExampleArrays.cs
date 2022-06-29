using System;
namespace ArraysCollections
{
    public class ExampleArrays
    {
        public void run()
        {
            int[] marks = new int[5] { 56, 84, 35, 72, 41 };
            //Console.WriteLine("Data at first location: " + marks[0]);
           // marks[0] = 58;
           // Console.WriteLine("Changed data at first location: " + marks[0]);
           // Console.WriteLine("Data at second location:" + marks[1]);
            // input all elements of the array
            Console.WriteLine("Enter 5 Numbers: ");
            for(int i = 0;i<marks.Length;i++)
                marks[i] = Convert.ToInt32(Console.ReadLine());
                // Print all elements of the array 
                Console.WriteLine("Print alll 5 Numbers:");
                  for(int i=0;i<marks.Length; i++)
                 Console.WriteLine(marks[i]);
            
        }
    }
}
