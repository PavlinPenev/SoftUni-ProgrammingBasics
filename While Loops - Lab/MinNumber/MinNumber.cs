using System;

namespace MinNumber
{
    class MinNumber
    {
        static void Main(string[] args)
        {
            int minNumber = int.MaxValue;
            string input = Console.ReadLine();
            while (input != "Stop")
            {
                int inputNum = int.Parse(input);
                if (inputNum < minNumber)
                {
                    minNumber = inputNum;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(minNumber);
        }
    }
}
