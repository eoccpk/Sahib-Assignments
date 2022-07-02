using System;
namespace InHeritance.With
{
    internal class Example
    {
        public void Run()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("========inheritance function call========");
            Console.WriteLine("=========================================");
            // Creating parent class object and saving in parent type variable
            Person person = new Person();
            // it will call parent class show 
            person.Show();
            Console.WriteLine("=========================================");
            // Creating child class object
            Student student = new Student();
            // it will call child class student show 
            student.Show();
            Console.WriteLine("==========================================");
            // Creating child class object 
            Teacher teacher = new Teacher();
            //it will call child class teacher show
            teacher.Show();
        }
    }
}
