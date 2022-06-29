using System;
namespace function
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int value = increase(50);
            Console.WriteLine("New value:" + value + "\n");
            int result = increase(10) * 5;
            Console.WriteLine("result:" + result + "\n");
            int marks = 80;
            Console.WriteLine(increase(marks));
            Console.ReadKey();
        }
        static int increase(int number) 
        {
            Console.WriteLine("i am print function");
            Console.WriteLine("i recieved:"+number);
            return number + 10;

        }
    }
}
