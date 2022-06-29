using System;
namespace Condition1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int passingmarks = 50;
            int marks =(int)Console.ReadLine();//55
            if (marks >= 50) ;
            {
                Console.WriteLine("pass");
            }
            else
            {
                Console.WriteLine("fail");
            }
            Console.ReadKey();
        }
    }
}
