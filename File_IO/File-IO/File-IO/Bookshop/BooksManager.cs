using System;
using System.IO;
namespace File_IO.Bookshop
{
    public class BooksManager
    {
        public void Write()
        {
            Console.WriteLine("====================================================");
            Console.WriteLine("=================BooksManager Write=================");
            Console.WriteLine("====================================================");
            List<Book> books = new List<Book>();
            Book book;
            for (int i = 0; i < 2; i++)
            {
                book = new Book();
                book.Input();
                books.Add(book);
               
            }
            // convert to json, csv or XML
            string data = JsonConvert.SerializeObject(books);
            //Saving Books
            File.WriteAllText("D:\\File_IO\\books.json", data);

        }
        public void Read()
        {
            Console.WriteLine("====================================================");
            Console.WriteLine("==============BooksManager Read=====================");
            Console.WriteLine("====================================================");
            //Read text file
            string data = File.ReadAllText("D:\\File_IO\\books.json");
            //convert string to list of objects 
            list<Book> books = JsonConvert.DeserializeObject<list<Book>>(data);
            foreach(Book book in books)
            {
               book.Print();
            }

        }
    }
}
