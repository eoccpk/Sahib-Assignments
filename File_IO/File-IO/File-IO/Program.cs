using System;
using System.IO;
namespace File_IO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ExampleTextFiles textFile = new ExampleTextFiles();
            // textFile.Write();
            // textFile.Read();
            //ExampleTextFiles2 exampleTextFiles2 = new ExampleTextFiles2();
            // exampleTextFiles2.Run();
           Bookshop. BooksManager manager = new Bookshop.BooksManager();
            manager.Write();
           // manager.Read();
            Console.ReadKey();
        }
    }
}
