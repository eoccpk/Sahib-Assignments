using System;
namespace Assignments3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Assignmentsconditions conditions = new Assignmentsconditions();
            // conditions.one();
            // conditions.Two();
            //conditions.Three();
            //conditions.Four();
            // conditions.Five();
            //AssignmentsLoops loops = new AssignmentsLoops();
            // loops.one();
            // loops.Two();
            // loops.Three();
            //loops.Four();
            //loops.Five();
             int a=Convert.ToInt32(Console.ReadLine());
            int b=Convert.ToInt32(Console.ReadLine());
            AssignmentsFunctions Functions = new AssignmentsFunctions();
            //Functions.One(a,b);
           
              //  Functions.Two(a, b);
             Functions.Area(a,b);
            // Functions.Four(a);

             //BooksManager manager = new BooksManager();
             //manager.Run();
            // AccountManger manager  = new AccountManager();
                // manager.Run();
               
            Console.ReadKey();
        }
    }
}
