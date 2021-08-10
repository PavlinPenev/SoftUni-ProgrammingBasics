using System;

namespace Number100_200
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());

            if (number1 < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (number1 >= 100 && number1 <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}
