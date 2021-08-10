using System;

namespace FruitShop
{
    class FruitShop
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day1 = Console.ReadLine();
            double quantity1 = double.Parse(Console.ReadLine());

            switch (day1)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    {
                        if (fruit == "banana")
                        {
                            Console.WriteLine($"{quantity1 * 2.50:f2}");
                        }
                        else if (fruit == "apple")
                        {
                            Console.WriteLine($"{quantity1 * 1.20:f2}");
                        }
                        else if (fruit == "orange")
                        {
                            Console.WriteLine($"{quantity1 * 0.85:f2}");
                        }
                        else if (fruit == "grapefruit")
                        {
                            Console.WriteLine($"{quantity1 * 1.45:f2}");
                        }
                        else if (fruit == "kiwi")
                        {
                            Console.WriteLine($"{quantity1 * 2.70:f2}");
                        }
                        else if (fruit == "pineapple")
                        {
                            Console.WriteLine($"{quantity1 * 5.50:f2}");
                        }
                        else if (fruit == "grapes")
                        {
                            Console.WriteLine($"{quantity1 * 3.85:f2}");
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }

                    }
                    break;
                case "Saturday":
                case "Sunday":
                    {
                        if (fruit == "banana")
                        {
                            Console.WriteLine($"{quantity1 * 2.70:f2}");
                        }
                        else if (fruit == "apple")
                        {
                            Console.WriteLine($"{quantity1 * 1.25:f2}");
                        }
                        else if (fruit == "orange")
                        {
                            Console.WriteLine($"{quantity1 * 0.90:f2}");
                        }
                        else if (fruit == "grapefruit")
                        {
                            Console.WriteLine($"{quantity1 * 1.60:f2}");
                        }
                        else if (fruit == "kiwi")
                        {
                            Console.WriteLine($"{quantity1 * 3.00:f2}");
                        }
                        else if (fruit == "pineapple")
                        {
                            Console.WriteLine($"{quantity1 * 5.60:f2}");
                        }
                        else if (fruit == "grapes")
                        {
                            Console.WriteLine($"{quantity1 * 4.20:f2}");
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                    }
                    break;
                default:
                    {
                        Console.WriteLine("error");
                    }
                    break;
            }
        }
    }
}
