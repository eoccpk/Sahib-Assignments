using System;
namespace Condition3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int passingmarks = 50;
            int marks = 55;
            char gender = 'm';
            if (marks>=passingmarks)
            {
                if (gender == 'm')
                {
                    Console.WriteLine("male is pass");
                }
                Console.ReadKey();
            }
        }
    }
}
