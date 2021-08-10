using System;

namespace OddEvenPosition
{
    class OddEvenPosition
    {
        static void Main(string[] args)
        {
            int input1 = int.Parse(Console.ReadLine());
            double evenSum = 0;
            double oddSum = 0;
            double minEven = double.MaxValue;
            double maxEven = double.MinValue;
            double minOdd = double.MaxValue;
            double maxOdd = double.MinValue;

            for (int i = 1; i <= input1; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += number;
                    if (number > maxEven)
                    {
                        maxEven = number;
                    }
                    if (number < minEven)
                    {
                        minEven = number;
                    }

                }
                else
                {
                    oddSum += number;
                    if (number > maxOdd)
                    {
                        maxOdd = number;
                    }
                    if (number < minOdd)
                    {
                        minOdd = number;
                    }
                }
            }
            Console.WriteLine($"OddSum={oddSum:f2},");
            Console.WriteLine((minOdd != double.MaxValue) ? $"OddMin={minOdd:f2}," : "OddMin=No,");
            Console.WriteLine((maxOdd != double.MinValue) ? $"OddMax={maxOdd:f2}," : "OddMax=No,");
            Console.WriteLine($"EvenSum={evenSum:f2},");
            Console.WriteLine((minEven != double.MaxValue) ? $"EvenMin={minEven:f2}," : "EvenMin=No,");
            Console.WriteLine((maxEven != double.MinValue) ? $"EvenMax={maxEven:f2}" : "EvenMax=No");
        }
    }
}
