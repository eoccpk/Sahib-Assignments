using System;
namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 25;
            int b = 30;
            int c = 55;
            if ((a > b) && (a > c))
            {
                Console.WriteLine("The greatest number is:" + a);
            }
            else if ((b > a) && (b > c))
            {
                Console.WriteLine("The greatest number is:" + b);
            }
            else if((c>a)&&(c>b))
            {
                Console.WriteLine("The greatest number is:" + c);
            }
            else
            {
                Console.WriteLine("All numbers are equal");
            }
            Console.ReadKey();
        }
    }
}
