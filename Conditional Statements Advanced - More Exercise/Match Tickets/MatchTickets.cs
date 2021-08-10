using System;

namespace MatchTickets
{
    class MatchTickets
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string ticketType = Console.ReadLine();
            int peopleCount = int.Parse(Console.ReadLine());

            double ticketVIP = 0;
            double ticketNormal = 0;
            double transportPrice = 0;
            double ticketPriceGroup = 0;

            if (peopleCount <= 4)
            {
                transportPrice = budget * 0.75;
            }
            else if (peopleCount <= 9)
            {
                transportPrice = budget * 0.60;
            }
            else if (peopleCount <= 24)
            {
                transportPrice = budget * 0.50;
            }
            else if (peopleCount <= 49)
            {
                transportPrice = budget * 0.40;
            }
            else
            {
                transportPrice = budget * 0.25;
            }

            switch (ticketType)
            {
                case "VIP":
                    ticketVIP = 499.99;
                    ticketPriceGroup = ticketVIP * peopleCount;
                    double diffInMoney = Math.Abs(budget - ticketPriceGroup - transportPrice);
                    Console.WriteLine(budget >= (ticketPriceGroup + transportPrice) ? $"Yes! You have {diffInMoney:f2} leva left." : $"Not enough money! You need {diffInMoney:f2} leva.");
                    break;
                case "Normal":
                    ticketNormal = 249.99;
                    ticketPriceGroup = ticketNormal * peopleCount;
                    diffInMoney = Math.Abs(budget - ticketPriceGroup - transportPrice);
                    Console.WriteLine(budget >= (ticketPriceGroup + transportPrice) ? $"Yes! You have {diffInMoney:f2} leva left." : $"Not enough money! You need {diffInMoney:f2} leva.");
                    break;
            }
        }
    }
}
