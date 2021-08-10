using System;

namespace FlowerShop
{
    class FlowerShop
    {
        static void Main(string[] args)
        {
            int magnolias = int.Parse(Console.ReadLine());
            int hyacinths = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int cactuses = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            double totalMagnoliaPrice = magnolias * 3.25;
            double totalHyacinthPrice = hyacinths * 4;
            double totalRosesPrice = roses * 3.5;
            double totalCactusesPrice = cactuses * 8;

            double earnings = totalCactusesPrice + totalHyacinthPrice + totalMagnoliaPrice + totalRosesPrice;
            double totalEarnings = earnings * 0.95;

            double EarningDifference = Math.Abs(totalEarnings - giftPrice);
            Console.WriteLine(totalEarnings >= giftPrice ? $"She is left with {Math.Floor(EarningDifference)} leva." : $"She will have to borrow {Math.Ceiling(EarningDifference)} leva.");
        }
    }
}
