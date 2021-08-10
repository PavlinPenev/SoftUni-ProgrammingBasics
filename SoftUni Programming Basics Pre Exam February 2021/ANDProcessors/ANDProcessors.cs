using System;

namespace ANDProcessors
{
    class ANDProcessors
    {
        static void Main(string[] args)
        {
            int CPUCount = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int workingDays = int.Parse(Console.ReadLine());

            int workingTime = workers * workingDays * 8;
            double processorsMade = Math.Floor((double)workingTime / 3);
            double difference = Math.Abs(CPUCount - processorsMade);
            Console.WriteLine(CPUCount > processorsMade ? $"Losses: -> {(difference * 110.10):f2} BGN" : $"Profit: -> {(difference * 110.10):f2} BGN");
        }
    }
}
