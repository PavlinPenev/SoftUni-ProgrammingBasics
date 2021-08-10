using System;

namespace FootballSouvenirs
{
    class FootballSouvenirs
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            string souvenirType = Console.ReadLine();
            int souvenirBought = int.Parse(Console.ReadLine());

            double souvenirPrice = 0;


            switch (team)
            {
                case "Argentina":
                    if (souvenirType == "flags")
                    {
                        souvenirPrice += 3.25;
                    }
                    else if (souvenirType == "caps")
                    {
                        souvenirPrice += 7.20;
                    }
                    else if (souvenirType == "posters")
                    {
                        souvenirPrice += 5.10;
                    }
                    else if (souvenirType == "stickers")
                    {
                        souvenirPrice += 1.25;
                    }
                    else
                    {
                        Console.WriteLine("Invalid stock!");
                        return;
                    }
                    break;
                case "Brazil":
                    if (souvenirType == "flags")
                    {
                        souvenirPrice += 4.20;
                    }
                    else if (souvenirType == "caps")
                    {
                        souvenirPrice += 8.50;
                    }
                    else if (souvenirType == "posters")
                    {
                        souvenirPrice += 5.35;
                    }
                    else if (souvenirType == "stickers")
                    {
                        souvenirPrice += 1.20;
                    }
                    else
                    {
                        Console.WriteLine("Invalid stock!");
                        return;
                    }
                    break;
                case "Croatia":
                    if (souvenirType == "flags")
                    {
                        souvenirPrice += 2.75;
                    }
                    else if (souvenirType == "caps")
                    {
                        souvenirPrice += 6.90;
                    }
                    else if (souvenirType == "posters")
                    {
                        souvenirPrice += 4.95;
                    }
                    else if (souvenirType == "stickers")
                    {
                        souvenirPrice += 1.10;
                    }
                    else
                    {
                        Console.WriteLine("Invalid stock!");
                        return;
                    }
                    break;
                case "Denmark":
                    if (souvenirType == "flags")
                    {
                        souvenirPrice += 3.10;
                    }
                    else if (souvenirType == "caps")
                    {
                        souvenirPrice += 6.50;
                    }
                    else if (souvenirType == "posters")
                    {
                        souvenirPrice += 4.80;
                    }
                    else if (souvenirType == "stickers")
                    {
                        souvenirPrice += 0.90;
                    }
                    else
                    {
                        Console.WriteLine("Invalid stock!");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid country!");
                    break;
            }
            double sumTotal = souvenirPrice * souvenirBought;
            if (team == "Argentina" || team == "Brazil" || team == "Croatia" || team == "Denmark")
            {
                Console.WriteLine($"Pepi bought {souvenirBought} {souvenirType} of {team} for {sumTotal:f2} lv.");
            }
        }
    }
}
