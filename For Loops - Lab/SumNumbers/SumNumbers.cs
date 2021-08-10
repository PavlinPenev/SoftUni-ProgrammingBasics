using System;

namespace SumNumbers
{
    class SumNumbers
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int value1 = 0;
            for (int i = 0; i < inputNumber; i++)
            {
                int sumNumber = int.Parse(Console.ReadLine());
                value1 += sumNumber;
            }
            Console.WriteLine(value1);
        }
    }
}
