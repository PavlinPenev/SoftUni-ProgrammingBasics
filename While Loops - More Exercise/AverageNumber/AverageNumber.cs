using System;

namespace AverageNumber
{
    class AverageNumber
    {
        static void Main(string[] args)
        {
            int input2 = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < input2; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine($"{((double)sum / input2):f2}");
        }
    }
}
