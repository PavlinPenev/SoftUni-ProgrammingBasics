using System;

namespace SumNumbers
{
    class SumNumbers
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            int sum1 = 0;
            while (sum1 < sum)
            {
                int numberToAdd = int.Parse(Console.ReadLine());
                sum1 += numberToAdd;
            }
            Console.WriteLine(sum1);
        }
    }
}
