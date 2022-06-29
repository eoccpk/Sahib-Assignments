using System;
namespace Assignments3
{
    public class AssignmentsLoops
    {
        public void one()
        {
            int counter = 0;
            while(counter < 5)
            {
                Console.WriteLine("Pakistan");
                counter++;
            }
            for (int i = 0; i < 5; i++) ;
            {
                Console.WriteLine("Pakistan");
            }
            
         
            }
          public void Two()
          {
            int counter = 1;
            while( counter <= 10)
            {
                Console.WriteLine(counter);
                counter++;
            }
        
          }
        public void Three()
        {
            int sum = 0;
            for(int counter=1;counter<=5;counter++)
            {
                sum=sum+counter;
            }
            Console.WriteLine("The sum of first 5 numbers:"+sum);
        }
        public void Four()
        {
            int counter = 1;
            while(counter<=5)
            {
                Console.WriteLine("Square of" + counter + "="+ (counter * counter));
                counter++;
            }
        }
        public void Five()
        {
            Console.WriteLine("Please enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=10;i++)
            {
                //3x1=3
                //3x6=18
                Console.WriteLine(n + "x" + i + "=" + (n * i));
            }
        }
    }
}
