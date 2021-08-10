using System;

namespace NumberInRange
{
    class NumberInRange
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            Console.WriteLine(number >= -100 && number != 0 && number <= 100 ? "Yes" : "No");
        }
    }
}
