using System;

namespace LeftAndRightSum
{
    class LeftAndRightSum
    {
        static void Main(string[] args)
        {
            int inputNumber2 = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;
            for (int i = 0; i < 2 * inputNumber2; i++)
            {
                int number1 = int.Parse(Console.ReadLine());
                if (i < inputNumber2)
                {
                    leftSum += number1;
                }
                else
                {
                    rightSum += number1;
                }
            }
            int diffInSum = Math.Abs(leftSum - rightSum);
            Console.WriteLine(leftSum == rightSum ? $"Yes, sum = {leftSum}" : $"No, diff = {diffInSum}");
        }
    }
}
