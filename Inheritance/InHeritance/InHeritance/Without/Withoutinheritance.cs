using System;
namespace InHeritance.Without
{
    public class Student
    {
        public string CNIC { get; set; }
        public string Name { get; set; }
        public int RollNumber { get; set; }
        public int Marks { get; set; }
        public void Show()
        {
            Console.WriteLine("CNIC: " + CNIC);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("RollNumber: " + RollNumber);
            Console.WriteLine("Marks: " + Marks);
        }
    }
    public class Teacher
    {
        public string CNIC { get; set; }

        public string Name { get; set; }
        public int EmployeeCode { get; set; }
        public string Subject { get; set; }
        public void Show()
        {
            Console.WriteLine("CNIC: " + CNIC);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("EmployeeCode: " + EmployeeCode);
            Console.WriteLine("Subject: " + Subject);
        }
    }
            public class Clerk
            {
                public string CNIC { get; set; }
                public string Name { get; set; }
                public string Duty { get; set; }
                public void Show()
                {
                   Console.WriteLine("CNIC: " + CNIC);
                   Console.WriteLine("Name: " + Name);
                   Console.WriteLine("Duty: " + Duty);


                }
            }
           
            

}

    

