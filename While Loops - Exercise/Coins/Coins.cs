using System;

namespace Coins
{
    class Coins
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine());
            double cents = Math.Round(change * 100, 2);
            int coinCounter = 0;

            while (cents > 0)
            {
                if (cents >= 200)
                {
                    coinCounter++; cents -= 200;
                }
                else if (cents >= 100)
                {
                    coinCounter++; cents -= 100;
                }
                else if (cents >= 50)
                {
                    coinCounter++; cents -= 50;
                }
                else if (cents >= 20)
                {
                    coinCounter++; cents -= 20;
                }
                else if (cents >= 10)
                {
                    coinCounter++; cents -= 10;
                }
                else if (cents >= 5)
                {
                    coinCounter++; cents -= 5;
                }
                else if (cents >= 2)
                {
                    coinCounter++; cents -= 2;
                }
                else if (cents >= 1)
                {
                    coinCounter++; cents -= 1;
                }
            }
            Console.WriteLine(coinCounter);
        }
    }
}
