using System;
using System.Collections.Generic;
namespace ArraysCollections
{
    internal class ExampleGenericList
    {
        public void Run()
        {
            List<Student> students = new List<Student>();
            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter student#" + (i + 1) + ":");
                Student student = new Student();
                student.input();
                students.Add(student);
            }
            // print all students
            Console.WriteLine("All students data: ");
            foreach(var s in students)
            {
                s.show();
            }
        }
    }
}
