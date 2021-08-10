using System;

namespace HalfSumElement
{
    class HalfSumElement
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int maxNumber = int.MinValue;
            int sum = 0;

            for (int i = 0; i < input; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;
                if (number > maxNumber)
                {
                    maxNumber = number;
                }

            }
            sum -= maxNumber;
            int diff = Math.Abs(sum - maxNumber);
            Console.WriteLine(sum == maxNumber ? $"Yes\nSum = {sum}" : $"No\nDiff = {diff}");
        }
    }
}
