using System;

namespace OddEvenSum
{
    class OddEvenSum
    {
        static void Main(string[] args)
        {
            int inputNumber3 = int.Parse(Console.ReadLine());

            int even = 0;
            int odd = 0;
            for (int i = 0; i < inputNumber3; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    even += number;
                }
                else
                {
                    odd += number;
                }
            }
            int diffInSum1 = Math.Abs(even - odd);
            Console.WriteLine(even == odd ? $"Yes\nSum = {even}" : $"No\nDiff = {diffInSum1}");
        }
    }
}
