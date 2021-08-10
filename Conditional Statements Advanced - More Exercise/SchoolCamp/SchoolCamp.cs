using System;

namespace SchoolCamp
{
    class SchoolCamp
    {
        static void Main(string[] args)
        {
            string season4 = Console.ReadLine();
            string groupType = Console.ReadLine();
            int students = int.Parse(Console.ReadLine());
            int nightsIn = int.Parse(Console.ReadLine());

            double priceForANight = 0;
            string sportType = "";
            double discount = 0;

            switch (season4)
            {
                case "Spring":
                    if (groupType == "boys" || groupType == "girls")
                    {
                        priceForANight = 7.20;
                    }
                    else
                    {
                        priceForANight = 9.50;
                    }
                    if (groupType == "boys")
                    {
                        sportType = "Tennis";
                    }
                    else if (groupType == "girls")
                    {
                        sportType = "Athletics";
                    }
                    else
                    {
                        sportType = "Cycling";
                    }
                    break;
                case "Summer":
                    if (groupType == "boys" || groupType == "girls")
                    {
                        priceForANight = 15;
                    }
                    else
                    {
                        priceForANight = 20;
                    }
                    if (groupType == "boys")
                    {
                        sportType = "Football";
                    }
                    else if (groupType == "girls")
                    {
                        sportType = "Volleyball";
                    }
                    else
                    {
                        sportType = "Swimming";
                    }
                    break;
                case "Winter":
                    if (groupType == "boys" || groupType == "girls")
                    {
                        priceForANight = 9.60;
                    }
                    else
                    {
                        priceForANight = 10;
                    }
                    if (groupType == "boys")
                    {
                        sportType = "Judo";
                    }
                    else if (groupType == "girls")
                    {
                        sportType = "Gymnastics";
                    }
                    else
                    {
                        sportType = "Ski";
                    }
                    break;
            }

            double priceForWholeCamp = nightsIn * priceForANight * students;
            if (students >= 50)
            {
                discount = priceForWholeCamp * 0.50;
            }
            else if (students < 50 && students >= 20)
            {
                discount = priceForWholeCamp * 0.15;
            }
            else if (students < 20 && students >= 10)
            {
                discount = priceForWholeCamp * 0.05;
            }

            double totalPrice = priceForWholeCamp - discount;

            Console.WriteLine($"{sportType} {totalPrice:f2} lv.");
        }
    }
}
