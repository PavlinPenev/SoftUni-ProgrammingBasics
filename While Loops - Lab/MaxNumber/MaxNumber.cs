using System;

namespace MaxNumber
{
    class MaxNumber
    {
        static void Main(string[] args)
        {
            int maxNumber = int.MinValue;
            string input = Console.ReadLine();
            while (input != "Stop")
            {
                int inputNum = int.Parse(input);
                if (inputNum > maxNumber)
                {
                    maxNumber = inputNum;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(maxNumber);
        }
    }
}
