using System;

namespace CarToGo
{
    class CarToGo
    {
        static void Main(string[] args)
        {
            double budget1 = double.Parse(Console.ReadLine());
            string season1 = Console.ReadLine();

            string carClass = "";
            string carType = "";
            double carRentPrice = 0;

            switch (season1)
            {
                case "Summer":
                    if (budget1 <= 100)
                    {
                        carClass = "Economy class";
                        carType = "Cabrio";
                        carRentPrice = budget1 * 0.35;
                    }
                    else if (budget1 > 100 && budget1 <= 500)
                    {
                        carClass = "Compact class";
                        carType = "Cabrio";
                        carRentPrice = budget1 * 0.45;
                    }
                    else
                    {
                        carClass = "Luxury class";
                        carType = "Jeep";
                        carRentPrice = budget1 * 0.90;
                    }
                    break;
                case "Winter":
                    if (budget1 <= 100)
                    {
                        carClass = "Economy class";
                        carType = "Jeep";
                        carRentPrice = budget1 * 0.65;
                    }
                    else if (budget1 > 100 && budget1 <= 500)
                    {
                        carClass = "Compact class";
                        carType = "Jeep";
                        carRentPrice = budget1 * 0.80;
                    }
                    else
                    {
                        carClass = "Luxury class";
                        carType = "Jeep";
                        carRentPrice = budget1 * 0.90;
                    }
                    break;
            }
            Console.WriteLine($"{carClass}");
            Console.WriteLine($"{carType} - {carRentPrice:f2}");
        }
    }
}
