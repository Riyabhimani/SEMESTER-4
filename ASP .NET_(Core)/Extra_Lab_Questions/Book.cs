using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Book
    {
        public int BookID;
        public string Title;
        public string Author;

        public Book(int bookID, string title, string author)
        {
            BookID = bookID;
            Title = title;
            Author = author;
        }

        public void DisplayBookDetails(int bookID, string title, string author)
        {
            Console.WriteLine("BookID = " + BookID);
            Console.WriteLine("Book Title = "+Title);
            Console.WriteLine("Book Author = "+Author);
        }
    }
}
