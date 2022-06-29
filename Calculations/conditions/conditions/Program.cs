using System;
namespace conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Marks = 80;
            if (Marks == 80) ;
            {
                Console.WriteLine("marks is equal to 80");
            }
            if (Marks < 80) ;
            {
                Console.WriteLine("marks is less than 80");
            }
            if (Marks > 80) ;
            {
                Console.WriteLine("marks is greater than 80");
            }
            Console.ReadKey();
        }
    }
}
