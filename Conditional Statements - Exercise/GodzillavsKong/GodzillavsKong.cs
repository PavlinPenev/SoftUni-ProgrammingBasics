using System;

namespace GodzillavsKong
{
    class GodzillavsKong
    {
        static void Main(string[] args)
        {
            double movieBudjet = double.Parse(Console.ReadLine());
            int extras = int.Parse(Console.ReadLine());
            double outfitPrice = double.Parse(Console.ReadLine());

            double decorPrice = movieBudjet * 0.10;
            double totalOutfitPrice = extras * outfitPrice;
            if (extras >= 150)
            {
                totalOutfitPrice *= 0.90;
            }

            double totalPrice = decorPrice + totalOutfitPrice;
            double diffInBudjet = Math.Abs(movieBudjet - totalPrice);
            
            Console.WriteLine(totalPrice > movieBudjet ? $"Not enough money!\nWingard needs {diffInBudjet:f2} leva more." : $"Action!\nWingard starts filming with { diffInBudjet:f2} leva left.");
            
        }
    }
}
