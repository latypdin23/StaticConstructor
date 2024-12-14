using System;

namespace StaticConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("Война и мир");
            Book b2 = new Book("Преступление и наказание");

            Console.ReadKey();
        }
    }
}
