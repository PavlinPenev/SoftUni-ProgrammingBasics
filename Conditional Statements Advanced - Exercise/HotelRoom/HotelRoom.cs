using System;

namespace HotelRoom
{
    class HotelRoom
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double priceStudio = 0;
            double priceApartment = 0;

            switch (month)
            {
                case "May":
                case "October":
                    priceStudio = 50;
                    priceApartment = 65;
                    break;
                case "June":
                case "September":
                    priceStudio = 75.20;
                    priceApartment = 68.70;
                    break;
                case "July":
                case "August":
                    priceStudio = 76;
                    priceApartment = 77;
                    break;
            }

            if (days > 7 && days <= 14 && (month == "May" || month == "October"))
            {
                priceStudio *= 0.95;
                priceApartment *= 1.00;
            }
            else if (days > 14 && (month == "May" || month == "October"))
            {
                priceStudio *= 0.70;
                priceApartment *= 0.90;
            }
            else if (days > 14 && (month == "June" || month == "September"))
            {
                priceStudio *= 0.80;
                priceApartment *= 0.90;
            }
            else if (days > 14)
            {
                priceStudio *= 1.00;
                priceApartment *= 0.90;
            }

            double priceTripAp = priceApartment * days;
            double priceTripSt = priceStudio * days;

            Console.WriteLine($"Apartment: {priceTripAp:f2} lv.");
            Console.WriteLine($"Studio: {priceTripSt:f2} lv.");
        }
    }
}
