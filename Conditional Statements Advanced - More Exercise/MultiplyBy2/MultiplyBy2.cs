using System;

namespace MultiplyBy2
{
    class MultiplyBy2
    {
        static void Main(string[] args)
        {
            double input = 0;

            while (input >= 0)
            {
                input = double.Parse(Console.ReadLine());
                Console.WriteLine(input >= 0 ? $"Result: {input * 2:f2}" : "Negative number!");
            }
        }
    }
}
