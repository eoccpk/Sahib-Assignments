using System;
namespace Assignments3
{
    public class AssignmentsFunctions
    {
        public void One(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine("First number:" + a + "is greter than second number:" + b);
            }
            else
            {
                Console.WriteLine("second number:" + b + "is greater than first number:" + a);
            }
        }
        public void Two(int a,int b)
        {
                AssignmentsCalculator Calculator=new AssignmentsCalculator();
                int result; 
            Console.WriteLine("add result ="+ Calculator.add(a,b));
            Console.WriteLine("subtract result = " + Calculator.subtract(a,b));
            Console.WriteLine("multiply result = " + Calculator.multiply(a,b));
            Console.WriteLine("divide result = "+ Calculator.divide(a,b));

        }
        public void Area(int lenght,int width)
        {
           AreaCalculator areacalculator = new AreaCalculator();
            Console.WriteLine("Area result ="+ areacalculator.Area(lenght,width));
        }
        public void Four(int n)
        {
            Console.WriteLine("===========Table of: " + n + "========");
            for ( int i = 1; i <= 10; i++) 
            {
                //3x1=3
                //3x4=12
                Console.WriteLine(n + "x" + i + "=" + (n * i));
            }
        }
        
    }
}
