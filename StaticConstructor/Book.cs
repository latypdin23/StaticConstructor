

using System;

namespace StaticConstructor
{
    internal class Book
    {
        public string Title { get; set; }
        public Book(string title)
        {
            Console.WriteLine("Вызван обычный конструктор");
            Title = title;
        }
        static Book()
        {
            Console.WriteLine("Вызван статический конструктор");
        }
    }
}
