using System;

namespace SumOfTwoNumbers
{
    class SumOfTwoNumbers
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int counter1 = 0;

            for (int i = firstNum; i <= secondNum; i++)
            {
                for (int u = firstNum; u <= secondNum; u++)
                {
                    counter1++;
                    if (i + u == magicNum)
                    {
                        Console.WriteLine($"Combination N:{counter1} ({i} + {u} = {magicNum})");
                        return;
                    }
                }

            }
            Console.WriteLine($"{counter1} combinations - neither equals {magicNum}");
        }
    }
}
