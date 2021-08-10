using System;

namespace TruckDriver
{
    class TruckDriver
    {
        static void Main(string[] args)
        {
            string season3 = Console.ReadLine();
            double kms = double.Parse(Console.ReadLine());

            double earningsPerKm = 0;
            switch (season3)
            {
                case "Spring":
                case "Autumn":
                    if (kms <= 5000)
                    {
                        earningsPerKm = 0.75;
                    }
                    else if (kms <= 10000)
                    {
                        earningsPerKm = 0.95;
                    }
                    else if (kms <= 20000)
                    {
                        earningsPerKm = 1.45;
                    }
                    break;
                case "Summer":
                    if (kms <= 5000)
                    {
                        earningsPerKm = 0.90;
                    }
                    else if (kms <= 10000)
                    {
                        earningsPerKm = 1.10;
                    }
                    else if (kms <= 20000)
                    {
                        earningsPerKm = 1.45;
                    }
                    break;
                case "Winter":
                    if (kms <= 5000)
                    {
                        earningsPerKm = 1.05;
                    }
                    else if (kms <= 10000)
                    {
                        earningsPerKm = 1.25;
                    }
                    else if (kms <= 20000)
                    {
                        earningsPerKm = 1.45;
                    }
                    break;
            }
            double totalEarnings = earningsPerKm * kms;
            double totalEarningsAfterTax = totalEarnings * 0.90;

            Console.WriteLine($"{(totalEarningsAfterTax * 4):f2}");
        }
    }
}
