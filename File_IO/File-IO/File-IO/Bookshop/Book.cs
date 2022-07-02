using System;
using System.IO;
namespace File_IO.Bookshop
{
    internal class Book
    {
       public string Tittle { get; set; }
        public string Author { get; set; }
        public int NumberofPages { get; set; }
        public int PublicationYear { get; set; }

        public void Input()
        {
            Console.WriteLine("Enter tittle: ");
            Tittle=Console.ReadLine();
            Console.WriteLine("Enter Author; ");
            Author=Console.ReadLine();
            Console.WriteLine(" Enter number of pages:");
            NumberofPages=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter publicationyear:");
            PublicationYear=Convert.ToInt32(Console.ReadLine());
        }
        public void Print()
        {
            Console.WriteLine("Tittle: " + Tittle);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Numberofpages: " + NumberofPages);
            Console.WriteLine("Publicationyear: " + PublicationYear);
        }
        public void  Borrow()
        {
          Console.WriteLine("Tittle: "+ Tittle);
        }
    }
}
