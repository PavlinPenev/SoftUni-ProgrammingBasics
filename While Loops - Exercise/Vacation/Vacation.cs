using System;

namespace Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {
            double tripMoney = double.Parse(Console.ReadLine());
            double moneyCash = double.Parse(Console.ReadLine());
            int dayCounter = 0;
            int spendRepeatCount = 0;
            while (moneyCash < tripMoney)
            {
                dayCounter++;
                string action = Console.ReadLine();
                double moneyForAction = double.Parse(Console.ReadLine());
                if (action == "spend")
                {
                    moneyCash -= moneyForAction;
                    if (moneyCash < 0)
                    {
                        moneyCash = 0;
                    }
                    spendRepeatCount++;
                }
                else if (action == "save")
                {
                    moneyCash += moneyForAction;
                    spendRepeatCount = 0;
                }
                if (spendRepeatCount >= 5)
                {
                    break;
                }

            }
            Console.WriteLine(spendRepeatCount >= 5 ? $"You can't save the money.\n{dayCounter}" : $"You saved the money for {dayCounter} days.");
        }
    }
}
