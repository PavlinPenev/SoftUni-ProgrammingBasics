using System;

namespace Dishwasher
{
    class Dishwasher
    {
        static void Main(string[] args)
        {
            double detergentCount = double.Parse(Console.ReadLine()) * 750;

            double operationCounter = 1;
            double dishesCounter = 0;
            double potsCounter = 0;
            while (detergentCount >= 0)
            {
                string dishesCount = Console.ReadLine();
                if (dishesCount == "End")
                {
                    break;
                }
                double dishes = double.Parse(dishesCount);
                if (operationCounter % 3 == 0)
                {
                    detergentCount -= dishes * 15;
                    potsCounter += dishes;
                }
                else
                {
                    detergentCount -= dishes * 5;
                    dishesCounter += dishes;
                }
                operationCounter++;
            }
            Console.WriteLine(detergentCount < 0 ? $"Not enough detergent, {Math.Abs(detergentCount)} ml. more necessary!" : $"Detergent was enough!\n{dishesCounter} dishes and {potsCounter} pots were washed.\nLeftover detergent {detergentCount} ml.");
        }
    }
}
