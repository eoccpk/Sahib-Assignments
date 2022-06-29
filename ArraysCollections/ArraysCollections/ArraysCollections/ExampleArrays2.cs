using System;
namespace ArraysCollections
{
    public class ExampleArrays2
    {
      //This function prints maximum number in the arry
      public void run()
      {
       int[] marks = new int[5];
            // input all elements of the array
            Console.WriteLine("Enter 5 Numbers:");
            for (int i = 0; i < marks.Length; i++)
             marks[i] = Convert.ToInt32(Console.ReadLine());
            int max = marks[0];//56
            for (int i = 0; i < marks.Length; i++)
            {
                //85>56 T
                //35>84 F
                //72>84 F
                //41>84 F
                //max=84
                if(marks[i] > max)
                   max = marks[i];
               
            }
            Console.WriteLine("Maximum Number is: " + max);
      }
    }
}
