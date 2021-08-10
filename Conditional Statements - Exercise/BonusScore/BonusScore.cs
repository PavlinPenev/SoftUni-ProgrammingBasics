using System;

namespace BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            int points = int.Parse(Console.ReadLine());

            if (points <= 100)
            {
                int bonusPoints = 5;
                if (points % 2 == 0)
                {
                    int evenBonusPoints = 1;
                    Console.WriteLine(bonusPoints + evenBonusPoints);
                    Console.WriteLine(points + bonusPoints + evenBonusPoints);
                }
                else if (points % 10 == 5)
                {
                    int fiveEndingBonusPoints = 2;
                    Console.WriteLine(bonusPoints + fiveEndingBonusPoints);
                    Console.WriteLine(points + bonusPoints + fiveEndingBonusPoints);
                }
                else
                {
                    Console.WriteLine(bonusPoints);
                    Console.WriteLine(points + bonusPoints);
                }
            }
            else if (points > 100 && points <= 1000)
            {
                double bonusPoints = points * 0.20;
                if (points % 2 == 0)
                {
                    int evenBonusPoints = 1;
                    Console.WriteLine(bonusPoints + evenBonusPoints);
                    Console.WriteLine(points + bonusPoints + evenBonusPoints);
                }
                else if (points % 10 == 5)
                {
                    int fiveEndingBonusPoints = 2;
                    Console.WriteLine(bonusPoints + fiveEndingBonusPoints);
                    Console.WriteLine(points + bonusPoints + fiveEndingBonusPoints);
                }
                else
                {
                    Console.WriteLine(bonusPoints);
                    Console.WriteLine(points + bonusPoints);
                }
            }
            else
            {
                double bonusPoints = points * 0.10;
                if (points % 2 == 0)
                {
                    int evenBonusPoints = 1;
                    Console.WriteLine(bonusPoints + evenBonusPoints);
                    Console.WriteLine(points + bonusPoints + evenBonusPoints);
                }
                else if (points % 10 == 5)
                {
                    int fiveEndingBonusPoints = 2;
                    Console.WriteLine(bonusPoints + fiveEndingBonusPoints);
                    Console.WriteLine(points + bonusPoints + fiveEndingBonusPoints);
                }
                else
                {
                    Console.WriteLine(bonusPoints);
                    Console.WriteLine(points + bonusPoints);
                }
            }
        }
    }
}
