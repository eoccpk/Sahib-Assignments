using System;
namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter a number");
            n =
                Convert.ToInt32(Console.ReadLine());
            if(n % 2==0)
            {
                Console.WriteLine("Entered number is an even number");
            }
            else
            {
                Console.WriteLine("Entered numberb is an odd number");
            }
            Console.ReadKey();
        }
    }
}
