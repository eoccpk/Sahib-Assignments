using System;
namespace Condition1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int PassingMarks = 50;
            int Marks = 90;
            if (Marks >= PassingMarks) 
            {
                Console.WriteLine("Pass");
            }
           else
            {
                Console.WriteLine("Fail");
            }
            Console.ReadKey();
        }
    }
}
