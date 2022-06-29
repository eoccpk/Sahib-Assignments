using System;
namespace Assignments3
{
    public class AssignmentsCalculator
    {
        public int add(int a,int b)
        {
            return a + b;
        }
        public int subtract(int a,int b)
        {
            return a - b;
        }
        public int multiply(int a,int b)
        {
            return a * b;
        }
        public int divide(int a,int b)
        {
            try
            {
                return a / b;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Calculation Error");
                return -999;
            }
            finally
            {
                Console.WriteLine("Done");
            }
        }
    }
}
