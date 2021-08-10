using System;

namespace DivideWithoutRemainder
{
    class DivideWithoutRemainder
    {
        static void Main(string[] args)
        {
            int input3 = int.Parse(Console.ReadLine());
            double[] counter1 = { 0, 0, 0 };

            //counter1[0] - без остатък на 2, counter1[1] - без остатък на 3, counter1[2] - без остатък на 4
            for (int i = 0; i < input3; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    counter1[0]++;
                }
                if (number % 3 == 0)
                {
                    counter1[1]++;
                }
                if (number % 4 == 0)
                {
                    counter1[2]++;
                }
            }
            Console.WriteLine($"{(counter1[0] / input3 * 100):f2}%");
            Console.WriteLine($"{(counter1[1] / input3 * 100):f2}%");
            Console.WriteLine($"{(counter1[2] / input3 * 100):f2}%");
        }
    }
}
