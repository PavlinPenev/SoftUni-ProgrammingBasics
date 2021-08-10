using System;

namespace GameOfIntervals
{
    class GameOfIntervals
    {
        static void Main(string[] args)
        {
            int moves = int.Parse(Console.ReadLine());
            double points = 0;
            double[] percentCounter = { 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < moves; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (number >= 0 && number < 10)
                {
                    points += (number * 0.20);
                    percentCounter[0]++;
                }
                else if (number >= 10 && number < 20)
                {
                    points += (number * 0.30);
                    percentCounter[1]++;
                }
                else if (number >= 20 && number < 30)
                {
                    points += (number * 0.40);
                    percentCounter[2]++;
                }
                else if (number >= 30 && number < 40)
                {
                    points += 50;
                    percentCounter[3]++;
                }
                else if (number >= 40 && number <= 50)
                {
                    points += 100;
                    percentCounter[4]++;
                }
                else
                {
                    points /= 2.00;
                    percentCounter[5]++;
                }
            }
            Console.WriteLine($"{points:f2}");
            Console.WriteLine($"From 0 to 9: {(percentCounter[0] / moves * 100):f2}% ");
            Console.WriteLine($"From 10 to 19: {(percentCounter[1] / moves * 100):f2}%");
            Console.WriteLine($"From 20 to 29: {(percentCounter[2] / moves * 100):f2}%");
            Console.WriteLine($"From 30 to 39: {(percentCounter[3] / moves * 100):f2}%");
            Console.WriteLine($"From 40 to 50: {(percentCounter[4] / moves * 100):f2}%");
            Console.WriteLine($"Invalid numbers: {(percentCounter[5] / moves * 100):f2}%");
        }
    }
}
