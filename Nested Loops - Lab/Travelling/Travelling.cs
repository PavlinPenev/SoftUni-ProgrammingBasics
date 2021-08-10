using System;

namespace Travelling
{
    class Travelling
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            while (destination != "End")
            {
                double budget = 0;
                double moneySaved = 0;
                double minBudget = double.Parse(Console.ReadLine());
                while (budget < minBudget)
                {
                    moneySaved = double.Parse(Console.ReadLine());
                    budget += moneySaved;
                }

                if (budget >= minBudget)
                {
                    Console.WriteLine($"Going to {destination}!");
                }
                destination = Console.ReadLine();
            }
        }
    }
}
