using System;

namespace NewHouse
{
    class NewHouse
    {
        static void Main(string[] args)
        {
            string flowersType = Console.ReadLine();
            int flowersAmount = int.Parse(Console.ReadLine());
            int Budget = int.Parse(Console.ReadLine());

            double price = 0;

            switch (flowersType)
            {
                case "Roses":
                    price = 5;
                    if (flowersAmount > 80)
                    {
                        price *= 0.90;
                    }
                    else
                    {
                        price = 5;
                    }
                    break;
                case "Dahlias":
                    price = 3.80;
                    if (flowersAmount > 90)
                    {
                        price *= 0.85;
                    }
                    else
                    {
                        price = 3.80;
                    }
                    break;
                case "Tulips":
                    price = 2.80;
                    if (flowersAmount > 80)
                    {
                        price *= 0.85;
                    }
                    else
                    {
                        price = 2.80;
                    }
                    break;
                case "Narcissus":
                    price = 3;
                    if (flowersAmount < 120)
                    {
                        price *= 1.15;
                    }
                    else
                    {
                        price = 3;
                    }
                    break;
                case "Gladiolus":
                    price = 2.50;
                    if (flowersAmount < 80)
                    {
                        price *= 1.20;
                    }
                    else
                    {
                        price = 2.50;
                    }
                    break;
            }
            double totalPrice = price * flowersAmount;
            double diffInBudget = Math.Abs(totalPrice - Budget);
            Console.WriteLine(totalPrice <= Budget ? $"Hey, you have a great garden with {flowersAmount} {flowersType} and {diffInBudget:f2} leva left." : $"Not enough money, you need {diffInBudget:f2} leva more.");
        }
    }
}
