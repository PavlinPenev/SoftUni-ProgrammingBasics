using System;

namespace ProgrammingBook
{
    class ProgrammingBook
    {
        static void Main(string[] args)
        {
            double printPage = double.Parse(Console.ReadLine());
            double printBorder = double.Parse(Console.ReadLine());
            int percentPaperPrint = int.Parse(Console.ReadLine());
            double designerCharge = double.Parse(Console.ReadLine());
            int crewPercentCharge = int.Parse(Console.ReadLine());

            double priceForBook = printPage * 899 + printBorder * 2;
            priceForBook = priceForBook - (priceForBook * ((double)percentPaperPrint / 100));
            priceForBook += designerCharge;
            double crewCharge = priceForBook * ((double)crewPercentCharge / 100);
            priceForBook -= crewCharge;

            Console.WriteLine($"Avtonom should pay {priceForBook:f2} BGN.");
        }
    }
}
