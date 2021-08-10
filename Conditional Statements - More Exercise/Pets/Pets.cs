using System;

namespace Pets
{
    class Pets
    {
        static void Main(string[] args)
        {
            int tripDays = int.Parse(Console.ReadLine());
            int foodKg = int.Parse(Console.ReadLine());
            double foodDailyDog = double.Parse(Console.ReadLine());
            double foodDailyCat = double.Parse(Console.ReadLine());
            double foodDailyTurtleGr = double.Parse(Console.ReadLine());

            double foodDailyTurtle = foodDailyTurtleGr / 1000;
            double totalFood = (foodDailyCat + foodDailyDog + foodDailyTurtle) * tripDays;

            double foodDifference = Math.Abs(totalFood - foodKg);
            Console.WriteLine(foodKg < totalFood ? $"{Math.Ceiling(foodDifference)} more kilos of food are needed." : $"{Math.Floor(foodDifference)} kilos of food left.");
        }
    }
}
