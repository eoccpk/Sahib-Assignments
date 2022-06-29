using System;
namespace Condition4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number of the day");
            int n = 1;
            switch (n)
            {
                case 1:
                    Console.WriteLine("monday");
                    break;
                case 2:
                    Console.WriteLine("tuesday");
                    break;
                case 3:
                    Console.WriteLine("wednesday");
                    break;
                case 4:
                    Console.WriteLine("thursday");
                    break;
                case 5:
                    Console.WriteLine("friday");
                    break;
                case 6:
                    Console.WriteLine("saturday");
                    break;
                case 7:
                    Console.WriteLine("sunday");
                    break;
                default:
                    break;

            }
            Console.ReadKey();
        }
    }
}
