using ConsoleApp1;

Book book  = new Book("C# for beginners", "Bill Gates", 1234567890);


book.Title = "C# for beginners";
book.Author = "Bill Gates";
book.ISBN= 1234567890;
book.DisplayBookInfo();

Book book1 = new Book("C# for beginners", "Bill Gates", 1234567890);

book1.Title = "Methods and classes";
book1.Author= "Microsft";
book1.ISBN = 234556;
book1.DisplayBookInfo();


