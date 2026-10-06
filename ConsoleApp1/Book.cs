using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Book
    {
        // private fields
        private string title;
        private string author;
        private int isbn;


        // public properties
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public int ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }
        //constructor
        public Book(string bookTitle, string bookAuthor, int BookISBN)
        {
            Title = bookTitle;
            Author = bookAuthor;
            ISBN = BookISBN;
        }

        //methods
        public void DisplayBookInfo()
        {
            Console.WriteLine($"Book Title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
        }

        // Parameterless constructor




    }
}
