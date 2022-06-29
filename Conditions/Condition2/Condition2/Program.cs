using System;
namespace Condition2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int passingmarks = 50;
            int marks = 55;
            char gender = 'm';
            if ((marks >= passingmarks) && (gender == 'm')) 
            {
                Console.WriteLine("male is pass");
            }
            if((marks>=passingmarks)&&(gender=='f'))
            {
                Console.WriteLine("femal is pass");
;            }
            int semester = 8;
            if((gender=='m')||(semester==8))
            {
                Console.WriteLine("eligibal");
            }
            Console.ReadKey();
        }
    }
}
