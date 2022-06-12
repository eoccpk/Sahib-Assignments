using System;
namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Age= 18;
            Console.WriteLine("Enter age");
            Age =
                Convert.ToInt32(Console.ReadLine());
            if(Age>=18)
            {
                Console.WriteLine("This person is eligible for casting vote");
            }
            else
            {
                Console.WriteLine("This person is not eligible for casting vote");
            }
            Console.ReadKey();
        }
    }
}
