using System;
namespace Assignments3.Bookshop
{
    public class BooksManager
    {
        public void run()
        {
            Book b1 = new Book();
            b1.input();
            b1.print();
            b1.borrow();

        }
    }
}
