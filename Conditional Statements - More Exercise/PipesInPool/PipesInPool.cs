using System;

namespace PipesInPool
{
    class PipesInPool
    {
        static void Main(string[] args)
        {
            double V = double.Parse(Console.ReadLine());
            double P1 = double.Parse(Console.ReadLine());
            double P2 = double.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());

            double waterFromP1 = P1 * H;
            double waterFromP2 = P2 * H;

            double waterFromBothPipes = waterFromP1 + waterFromP2;

            if (waterFromBothPipes <= V)
            {
                double percentWater = (waterFromBothPipes / V) * 100;
                double percentP1 = (waterFromP1 / waterFromBothPipes) * 100;
                double percentP2 = (waterFromP2 / waterFromBothPipes) * 100;
                Console.WriteLine($"The pool is {percentWater:f2}% full. Pipe 1: {percentP1:f2}%. Pipe 2: {percentP2:f2}%.");
            }
            else
            {
                double waterOut = waterFromBothPipes - V;
                Console.WriteLine($"For {H} hours the pool overflows with {waterOut:f2} liters.");
            }
        }
    }
}
