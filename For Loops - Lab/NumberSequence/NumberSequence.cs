using System;

namespace NumberSequence
{
    class NumberSequence
    {
        static void Main(string[] args)
        {
            int inputNumber1 = int.Parse(Console.ReadLine());
            int compareNumber = 0;
            int minNumber = 0;
            int maxNumber = 0;
            for (int i = 0; i < inputNumber1; i++)
            {
                compareNumber = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    maxNumber = compareNumber;
                    minNumber = compareNumber;
                }
                if (compareNumber > maxNumber)
                {
                    maxNumber = compareNumber;
                }
                else if (compareNumber < minNumber)
                {
                    minNumber = compareNumber;
                }
            }
            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
        }
    }
}
