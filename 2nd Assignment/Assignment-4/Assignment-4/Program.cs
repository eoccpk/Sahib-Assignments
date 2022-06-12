using System;
namespace Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int sum = 0;
            for(i=1;i<6;i++)
            {
                sum = sum + i;
                Console.WriteLine(i);
            }
            Console.WriteLine("The total sum is:" + sum);
            Console.ReadLine();
        }
    }
}
