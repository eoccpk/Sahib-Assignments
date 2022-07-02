using System;
namespace InHeritance.With
{
    public class Person
    {
        public string CNIC { get; set; }
        public string Name { get; set; }
        public void Show()
        {
            Console.WriteLine("CNIC: " + CNIC);
            Console.WriteLine("Name: " + Name);

        }

    }
    public class Student : Person
    {
        public int RollNumber { get; set; }
        public int Marks { get; set; }
        public  void Show()
        {
            base.Show();
            Console.WriteLine("RollNumber: " + RollNumber);
            Console.WriteLine("Marks: " + Marks);

        }

    }
    public class Teacher : Person
    {
        public int EmployeeCode { get;set; }
        public string Subject { get; set; } 
        public  void  Show()
        {
            base.Show();
            Console.WriteLine("EmployeeCode: " + EmployeeCode);
            Console.WriteLine("Subject: " + Subject);
        }
    }
    public class Clerk : Person
    {
        public string Duty { get; set; }
        public void Show()
        {
            base.Show();
            Console.WriteLine("Duty: " + Duty);
        }
    }
}

