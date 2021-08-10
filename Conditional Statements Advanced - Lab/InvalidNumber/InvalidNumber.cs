using System;

namespace InvalidNumber
{
    class InvalidNumber
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            bool valid = (number1 >= 100 && number1 <= 200) || number1 == 0;
            if (!valid)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}