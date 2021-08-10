using System;

namespace AccountBalance
{
    class AccountBalance
    {
        static void Main(string[] args)
        {
            double totalDeposit = 0;
            string moneyDeposit = Console.ReadLine();
            while (moneyDeposit != "NoMoreMoney")
            {
                double moneyDepositNum = double.Parse(moneyDeposit);

                if (moneyDepositNum >= 0)
                {
                    totalDeposit += moneyDepositNum;
                    Console.WriteLine($"Increase: {moneyDepositNum:f2}");
                }
                else
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                moneyDeposit = Console.ReadLine();
            }
            Console.WriteLine($"Total: {totalDeposit:f2}");
        }
    }
}
