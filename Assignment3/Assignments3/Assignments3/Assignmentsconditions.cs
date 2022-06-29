using System;
namespace Assignments3
{
    public class Assignmentsconditions
    {
        public void one()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine("Both numbers are equal");
            }
            else
            {
                Console.WriteLine("Numbers are Not equal");
            }
        }
        public void Two()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine("This number is positive:" + a);
            }
            else if (a < 0)
            {
                Console.WriteLine("This number is negitive:" + a);
            }
        }
        public void Three()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("This number is even:" + a);
            }
            else
            {
                Console.WriteLine("This number is ODD:" + a);
            }
        }
        public void Four()
        {
            Console.WriteLine("Please enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("You are Eligible");
            }
            else
            {
                Console.WriteLine("You are not Eligible");
            }
        }
        public void Five()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine(a + "is maximum");
            }
;               if(b > a && b > c)
            {
                Console.WriteLine(b + "is maximum");
            }
            else
            {
                Console.WriteLine(c + "is maximum");
            }
        }
    }
}