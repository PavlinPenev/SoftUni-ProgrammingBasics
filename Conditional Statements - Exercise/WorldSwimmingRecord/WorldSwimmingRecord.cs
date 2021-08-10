using System;

namespace WorldSwimmingRecord
{
    class WorldSwimmingRecord
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timePerMeter = double.Parse(Console.ReadLine());

            double timesDelayed = Math.Floor(distance / 15);
            double secondsDelayed = (timesDelayed * 12.5);
            double swimmingWithoutDelay = (distance * timePerMeter);
            double totalSwimmingTime = (swimmingWithoutDelay + secondsDelayed);

            double diffInTime = Math.Abs(totalSwimmingTime - worldRecord);
            Console.WriteLine(totalSwimmingTime < worldRecord ? $"Yes, he succeeded! The new world record is {totalSwimmingTime:f2} seconds." : $"No, he failed! He was {diffInTime:f2} seconds slower.");
        }
    }
}
