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


        public void DisplayBookInfo()
        {
            Console.WriteLine($"Book Title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
        }
    }
}
