using System;

namespace C_Practice
{
    // Experimenting with C# properties. Shorthand setters/getters
    class Book 
    {
        public string Title { get; set; }
        public int NumPages { get; set; }
        public float Price { get; set; }
        public string Secret { private get; set; }

        public Book() {
            // Empty constructor, can use setters
        }

        public Book(string title, int numPages, float price) {
            Title = title;
            NumPages = numPages;
            Price = price;
        }

        public void describe() {
            Console.WriteLine(String.Format("The book is called {0} and it contains {1} pages, at a price of ${2}", Title, NumPages, Price.ToString("0.00")));
        }
    } // end Book class block
    class Program
    {
        static void return_name() {
            Console.WriteLine(new String('*', 10) + " Beginning return_name block\r\n");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Oh I see, your name is " + name);
            Console.WriteLine(new String('*', 10) + " End return_name block\r\n");
        }
        static void Main(string[] args)
        {
            // Basic reading from input
            return_name();

            // Object oriented practice. Setters, getters, overloaded constructors, type casting, etc.
            Book book1 = new Book("Harry Potter", 321, (float)17.50);
            book1.describe();

            // Create Random object to create numPages and price for each book
            Random rnd = new Random();
            // Create array[10] of books and describe with for loop after adding to array
            Book[] books = new Book[10];
            Console.WriteLine(books.Length);
            for (int i = 0; i < 10; i++) {
                int numPages = rnd.Next(20, 685);
                decimal price = Math.Round(new decimal(rnd.NextDouble()), 3);
                price = price * 80 + 3;
                string bookName = "Book #" + i.ToString();
                Book book = new Book(bookName, numPages, (float)price);
                books[i] = book;
            }
            Console.WriteLine(new String('-', 5) + " Info of all created books:\r\n");

            foreach (Book book in books) {
                book.describe();
            }
        }
    }
}
