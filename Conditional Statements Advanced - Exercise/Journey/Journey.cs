using System;

namespace Journey
{
    class Journey
    {
        static void Main(string[] args)
        {
            double budget1 = double.Parse(Console.ReadLine());
            string season1 = Console.ReadLine();

            double tripPrice = 0;
            string destination = "";
            string roomType = "";

            if (budget1 <= 100)
            {
                destination = "Bulgaria";
                if (season1 == "summer")
                {
                    tripPrice = budget1 * 0.3;
                }
                else if (season1 == "winter")
                {
                    tripPrice = budget1 * 0.70;
                }
            }
            else if (budget1 <= 1000)
            {
                destination = "Balkans";
                if (season1 == "summer")
                {
                    tripPrice = budget1 * 0.4;
                }
                else if (season1 == "winter")
                {
                    tripPrice = budget1 * 0.80;
                }
            }
            else
            {
                destination = "Europe";
                tripPrice = budget1 * 0.90;
            }

            switch (season1)
            {
                case "summer":
                    if (destination == "Europe")
                    {
                        roomType = "Hotel";
                    }
                    else
                    {
                        roomType = "Camp";
                    }
                    break;
                case "winter":
                    roomType = "Hotel";
                    break;
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{roomType} - {tripPrice:f2}");
        }
    }
}
