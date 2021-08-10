using System;

namespace FishingBoat
{
    class FishingBoat
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());

            double rentPrice = 0.00;

            switch (season)
            {
                case "Spring":
                    rentPrice = 3000;
                    if (fishermen <= 6)
                    {
                        rentPrice *= 0.90;
                    }
                    else if (fishermen >= 7 && fishermen <= 11)
                    {
                        rentPrice *= 0.85;
                    }
                    else
                    {
                        rentPrice *= 0.75;
                    }
                    break;
                case "Summer":
                case "Autumn":
                    rentPrice = 4200;
                    if (fishermen <= 6)
                    {
                        rentPrice *= 0.90;
                    }
                    else if (fishermen >= 7 && fishermen <= 11)
                    {
                        rentPrice *= 0.85;
                    }
                    else
                    {
                        rentPrice *= 0.75;
                    }
                    break;
                case "Winter":
                    rentPrice = 2600;
                    if (fishermen <= 6)
                    {
                        rentPrice *= 0.90;
                    }
                    else if (fishermen >= 7 && fishermen <= 11)
                    {
                        rentPrice *= 0.85;
                    }
                    else
                    {
                        rentPrice *= 0.75;
                    }
                    break;
            }

            if (fishermen % 2 == 0 && season != "Autumn")
            {
                rentPrice *= 0.95;
            }

            double diffInBudget1 = Math.Abs(rentPrice - budget);
            Console.WriteLine(budget >= rentPrice ? $"Yes! You have {diffInBudget1:f2} leva left." : $"Not enough money! You need {diffInBudget1:f2} leva.");
        }
    }
}
