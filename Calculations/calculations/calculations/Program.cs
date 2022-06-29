using System;
namespace calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;
            int c;
            c = a + b;
            Console.WriteLine("Result:" + c);
            c = a - b;
            Console.WriteLine("Result:" + c);
            c = a * b;
            Console.WriteLine("Result:" + c);
            c = a / b;
            Console.WriteLine("Result:" + c);
            Console.ReadLine();
        }
    }
}
