using System;
namespace InHeritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //With.Example WithExample = new With.Example();
           //WithExample.Run();
           Without.Example  WithoutExample = new Without.Example();
            WithoutExample.Run();
            Console.ReadKey();
        }
    }
}
