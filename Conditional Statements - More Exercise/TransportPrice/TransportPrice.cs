using System;

namespace TransportPrice
{
    class TransportPrice
    {
        static void Main(string[] args)
        {
            int km = int.Parse(Console.ReadLine());
            string TimeOfDay = Console.ReadLine();

            if (km >= 100)
            {
                double priceForTrain = km * 0.06;
                Console.WriteLine($"{priceForTrain:f2}");
            }
            else if (km >= 20 && km < 100)
            {
                double priceForBus = km * 0.09;
                Console.WriteLine($"{priceForBus:f2}");
            }
            else
            {
                double priceForTaxiNight = km * 0.9 + 0.70;
                double priceForTaxiDay = km * 0.79 + 0.70;
                Console.WriteLine(TimeOfDay == "night" ? $"{priceForTaxiNight:f2}" : $"{priceForTaxiDay:f2}");
            }
        }
    }
}
