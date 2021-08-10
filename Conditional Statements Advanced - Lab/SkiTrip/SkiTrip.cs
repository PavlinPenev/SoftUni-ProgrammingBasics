using System;

namespace SkiTrip
{
    class SkiTrip
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string feedback = Console.ReadLine();

            double finalPrice = 0;
            double price = 0;
            switch (roomType)
            {
                case "room for one person":
                    price = 18;
                    break;
                case "apartment":
                    price = 25;
                    if (days < 10)
                    {
                        price *= 0.70;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        price *= 0.65;
                    }
                    else if (days > 15)
                    {
                        price *= 0.50;
                    }
                    break;
                case "president apartment":
                    price = 35;
                    if (days < 10)
                    {
                        price *= 0.90;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        price *= 0.85;
                    }
                    else if (days > 15)
                    {
                        price *= 0.80;
                    }
                    break;
            }
            finalPrice = (days - 1) * price;

            if (feedback == "positive")
            {
                finalPrice = finalPrice + (finalPrice * 0.25);
            }
            else
            {
                finalPrice = finalPrice - (finalPrice * 0.10);
            }

            Console.WriteLine($"{finalPrice:f2}");
        }
    }
}
