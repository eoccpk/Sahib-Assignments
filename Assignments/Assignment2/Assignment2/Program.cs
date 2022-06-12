using System;
namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter a number");
            n=
            Convert.ToInt32(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine("number is zero");
            }
            else if (n > 0)
            {
                Console.WriteLine("number is positive");
            }
            else
            {
                Console.WriteLine("number is negative");
            }
            Console.ReadLine();
        }
    }
}
