using System;

namespace ReportSystem
{
    class ReportSystem
    {
        static void Main(string[] args)
        {
            int charityGoal = int.Parse(Console.ReadLine());
            double moneyCollectedCash = 0.00;
            double moneyCollectedCard = 0.00;
            int evenOddCounter = 1;
            int paymentCounterCash = 0;
            int paymentCounterCard = 0;
            string input = "";
            while (moneyCollectedCard + moneyCollectedCash < charityGoal)
            {

                input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                double money = double.Parse(input);
                if (evenOddCounter % 2 == 0)
                {

                    if (money < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        moneyCollectedCard += money;
                        paymentCounterCard++;
                    }
                }
                else
                {
                    if (money > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        moneyCollectedCash += money;
                        paymentCounterCash++;
                    }
                }
                evenOddCounter++;
            }
            Console.WriteLine(input == "End" ? "Failed to collect required money for charity." : $"Average CS: {(moneyCollectedCash / paymentCounterCash):f2}\nAverage CC: {(moneyCollectedCard / paymentCounterCard):f2}");
        }
    }
}
