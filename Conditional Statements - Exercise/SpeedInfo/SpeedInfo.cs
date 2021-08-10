using System;
using System.Runtime.Serialization.Formatters;

namespace SpeedInfo
{
    class SpeedInfo
    {
        static void Main(string[] args)
        {
            double speed = double.Parse(Console.ReadLine());
            string print = string.Empty;
            if (speed <= 10)
            {
                print = "slow";
            }
            else if (speed > 10 && speed <= 50)
            {
                print = "average";
            }
            else if (speed > 50 && speed <= 150)
            {
                print = "fast";
            }
            else if (speed > 150 && speed <= 1000)
            {
                print = "ultra fast";
            }
            else
            {
                print = "extremely fast";
            }

            Console.WriteLine(print);
        }
    }
}
