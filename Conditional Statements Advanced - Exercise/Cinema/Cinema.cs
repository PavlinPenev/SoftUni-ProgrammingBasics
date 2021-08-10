using System;

namespace Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            string projectionType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            int fullHall = rows * columns;
            double price = 0;

            switch (projectionType)
            {
                case "Premiere":
                    price = 12;
                    break;
                case "Normal":
                    price = 7.50;
                    break;
                case "Discount":
                    price = 5.00;
                    break;
            }
            double priceFullHall = price * fullHall;

            Console.WriteLine($"{priceFullHall:f2} leva");
        }
    }
}
