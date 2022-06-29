using System;
namespace Assignments3.Bookshop
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Numbersofpages { get; set; }
        public int Publicationyear { get; set; }
        public void input()
        {
            Console.WriteLine("Enter Tittle:");
            Title = Console.ReadLine();
            Console.WriteLine("Enter Author:");
            Author = Console.ReadLine();
            Console.WriteLine("Enter Numberofpages:");
            Numbersofpages = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Publicationyear:");
            Publicationyear = Convert.ToInt32(Console.ReadLine());
        }
        public void print()
        {
            Console.WriteLine("Title:" + Title);
            Console.WriteLine("Author:" + Author);
            Console.WriteLine("Numberofpages:" + Numbersofpages);
            Console.WriteLine("Publicationyear:" + Publicationyear);
        }
        public void borrow()
        {
         Console.WriteLine("Title:"+Title);
        }
    }


}
