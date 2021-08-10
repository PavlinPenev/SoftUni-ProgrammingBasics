using System;

namespace Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {
            double budget2 = double.Parse(Console.ReadLine());
            string season2 = Console.ReadLine();

            string destination = "";
            string stayingAt = "";
            double price = 0;

            switch (season2)
            {
                case "Summer":
                    if (budget2 <= 1000)
                    {
                        stayingAt = "Camp";
                        destination = "Alaska";
                        price = budget2 * 0.65;
                    }
                    else if (budget2 > 1000 && budget2 <= 3000)
                    {
                        stayingAt = "Hut";
                        destination = "Alaska";
                        price = budget2 * 0.80;
                    }
                    else
                    {
                        stayingAt = "Hotel";
                        destination = "Alaska";
                        price = budget2 * 0.90;
                    }
                    break;
                case "Winter":
                    if (budget2 <= 1000)
                    {
                        stayingAt = "Camp";
                        destination = "Morocco";
                        price = budget2 * 0.45;
                    }
                    else if (budget2 > 1000 && budget2 <= 3000)
                    {
                        stayingAt = "Hut";
                        destination = "Morocco";
                        price = budget2 * 0.60;
                    }
                    else
                    {
                        stayingAt = "Hotel";
                        destination = "Morocco";
                        price = budget2 * 0.90;
                    }
                    break;
            }

            Console.WriteLine($"{destination} - {stayingAt} - {price:f2}");
        }
    }
}
