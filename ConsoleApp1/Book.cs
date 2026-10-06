using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Book
    {

        public string Title;

        public string Author;

        public int ISBN;

        // Parameterless constructor
      
        public Book(string bookTitle, string bookAuthor, int BookISBN )
        {
            Title = bookTitle;
            Author = bookAuthor;
            ISBN = BookISBN;
        }

        public void DisplayBookInfo()
        {
            Console.WriteLine($"Book Title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
        }
    }
}
