using InterfaceSegregation.Library;
using System;

namespace InterfaceSegregation
{
    class Program
    {
        static void Main(string[] args)
        {
            IBorrowableBook book = new Book();
            book.CheckIn();


            Console.ReadLine();
        }
    }
}
