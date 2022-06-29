using System;
namespace ArraysCollections
{
    internal class Student
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }
        public int[] Marks { get; set; }
        public Student()
        {
            RollNumber = 1;
            Name = "Default name";
            Marks = new int[3];
        }
        public Student(int rollnumber, string name, int[] marks)
        {
            RollNumber = rollnumber;
            Name = name;
            Marks = marks;
        }
        public void input()
        {
            Console.WriteLine("Roll#: ");
            RollNumber=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter 3 Marks: ");
            for(int i = 0; i < Marks.Length; i++)
                Marks[i]=Convert.ToInt32(Console.ReadLine());
        }
        public void show()
        {
            Console.WriteLine("Roll Number: "+ RollNumber );
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Marks: " + String.Join(" ",Marks));
        }
    }
}
