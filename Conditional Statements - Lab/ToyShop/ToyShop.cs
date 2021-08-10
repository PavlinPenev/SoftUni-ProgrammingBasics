using System;

namespace ToyShop
{
    class ToyShop
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int quantityPuzzles = int.Parse(Console.ReadLine());
            int quantityDolls = int.Parse(Console.ReadLine());
            int quantityBears = int.Parse(Console.ReadLine());
            int quantityMinions = int.Parse(Console.ReadLine());
            int quantityTrucks = int.Parse(Console.ReadLine());

            double priceForToys = quantityPuzzles * 2.6 + quantityDolls * 3 + quantityBears * 4.1 + quantityMinions * 8.2 + quantityTrucks * 2;
            int quantityAllToys = quantityPuzzles + quantityDolls + quantityBears + quantityMinions + quantityTrucks;

            if (quantityAllToys >= 50)
            {
                priceForToys = priceForToys * 0.75;
            }

            double rent = priceForToys * 0.10;
            double totalEarnings = priceForToys - rent;
            Console.WriteLine(totalEarnings >= tripPrice ? $"Yes! {(totalEarnings - tripPrice):f2} lv left." : $"Not enough money! {(tripPrice - totalEarnings):f2} lv needed.");
        }
    }
}
