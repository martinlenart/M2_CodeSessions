using System;

namespace BookShelf
{
    public enum Author
    {
        Mark_Twain, JK_Rolling
    }
    public struct Book
    {
        public Author Author;
        public string Title;
    }
     class Program
    {
        static void Main(string[] args)
        {
            Book[] shelf = new Book[5];

            Console.WriteLine("Hello World!");
        }
    }
}
