using System;

namespace CleverLilly
{
    class CleverLilly
    {
        static void Main(string[] args)
        {
            int ageLilly = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            double toysPrice = double.Parse(Console.ReadLine());

            int toysCounter = 0;
            int birthdayMoney = 0;
            int evenBdayCounter = 0;
            int stolenMoney = 0;
            for (int i = 1; i <= ageLilly; i++)
            {
                if (i % 2 == 0)
                {
                    birthdayMoney += evenBdayCounter * 10;
                    evenBdayCounter += 1;
                }
                else if (i % 2 != 0 && i != 0)
                {
                    toysCounter += 1;
                }
            }
            birthdayMoney += (evenBdayCounter * 10);
            stolenMoney = evenBdayCounter * 1;
            double toysPriceSum = toysPrice * toysCounter;
            double moneyCollected = toysPriceSum + birthdayMoney - stolenMoney;
            double diffInMoney = Math.Abs(moneyCollected - washingMachinePrice);
            Console.WriteLine(moneyCollected >= washingMachinePrice ? $"Yes! {diffInMoney:f2}" : $"No! {diffInMoney:f2}");
        }
    }
}
