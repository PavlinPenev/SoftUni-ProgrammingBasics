using System;

namespace OldBooks
{
    class OldBooks
    {
        static void Main(string[] args)
        {
            string favBook = Console.ReadLine();
            int counter = 0;
            string inputBook = Console.ReadLine();
            while (inputBook != "No More Books" && inputBook != favBook)
            {
                counter++;
                inputBook = Console.ReadLine();
            }
            Console.WriteLine(inputBook != favBook ? $"The book you search is not here!\nYou checked {counter} books." : $"You checked {counter} books and found it.");
        }
    }
}
