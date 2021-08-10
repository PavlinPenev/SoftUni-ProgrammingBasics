using System;

namespace EqualPairs
{
    class EqualPairs
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int sum = 0;
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i < input; i++)
            {
                int number1 = int.Parse(Console.ReadLine());
                int number2 = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    sum += number1 + number2;
                }
                else
                {
                    sum -= (number1 + number2);
                }

                if (i == input - 2)
                {
                    sum1 = number1 + number2;
                }
                sum2 = number1 + number2;
            }
            int diffInSums = Math.Abs(sum1 - sum2);
            Console.WriteLine(sum == 0 || sum == sum2 ? $"Yes, value={sum2}" : $"No, maxdiff={diffInSums}");
        }
    }
}
