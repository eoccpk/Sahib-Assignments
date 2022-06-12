using System;
namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            Console.WriteLine("input for number1 and number2");
            num1 =
                Convert.ToInt32(Console.ReadLine());
            num2 =
                Convert.ToInt32(Console.ReadLine());
            if (num1==num2)
            {
                Console.WriteLine("first number is equal to 2nd number");
            }
            else
            {
                Console.WriteLine("first number is not equalto 2nd number");
            }
            Console.ReadKey();
        }
    }
}
