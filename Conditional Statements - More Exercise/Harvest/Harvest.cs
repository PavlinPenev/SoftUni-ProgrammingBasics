using System;

namespace Harvest
{
    class Harvest
    {
        static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());
            double grapesPerSqm = double.Parse(Console.ReadLine());
            double wineNeeded = double.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double grapesHarvested = area * grapesPerSqm;
            double grapesForWine = grapesHarvested * 0.40;
            double wineProduced = grapesForWine / 2.5;

            double diffInWine = Math.Abs(wineNeeded - wineProduced);

            if (wineProduced < wineNeeded)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(diffInWine)} liters wine needed.");
            }
            else
            {
                double winePerWorker = diffInWine / workers;
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wineProduced)} liters.");
                Console.WriteLine($"{Math.Ceiling(diffInWine)} liters left -> {Math.Ceiling(winePerWorker)} liters per person.");
            }
        }
    }
}
