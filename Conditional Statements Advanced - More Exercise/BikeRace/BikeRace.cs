using System;

namespace BikeRace
{
    class BikeRace
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string roadType = Console.ReadLine();

            double entryFeeJuniors = 0;
            double entryFeeSeniors = 0;

            switch (roadType)
            {
                case "trail":
                    entryFeeSeniors = 7.00;
                    entryFeeJuniors = 5.50;
                    break;
                case "cross-country":
                    entryFeeJuniors = 8.00;
                    entryFeeSeniors = 9.50;
                    break;
                case "downhill":
                    entryFeeJuniors = 12.25;
                    entryFeeSeniors = 13.75;
                    break;
                case "road":
                    entryFeeJuniors = 20;
                    entryFeeSeniors = 21.50;
                    break;
            }
            double moneyGathered = juniors * entryFeeJuniors + seniors * entryFeeSeniors;
            if (roadType == "cross-country" && juniors + seniors >= 50)
            {
                moneyGathered *= 0.75;
            }

            double totalMoney = moneyGathered * 0.95;
            Console.WriteLine($"{totalMoney:f2}");
        }
    }
}
