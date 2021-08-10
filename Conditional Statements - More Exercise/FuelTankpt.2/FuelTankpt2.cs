using System;

namespace FuelTankpt2
{
    class FuelTankpt2
    {
        static void Main(string[] args)
        {
            string fuelType1 = Console.ReadLine();
            if (fuelType1 != "Gas" && fuelType1 != "Diesel" && fuelType1 != "Gasoline")
            {
                return;
            }
            double fuelAmount = double.Parse(Console.ReadLine());
            string clubCard = Console.ReadLine();
            if (clubCard != "Yes" && clubCard != "No")
            {
                return;
            }


            if (clubCard == "Yes")
            {
                if (fuelType1 == "Gas")
                {
                    double fuelPrice = fuelAmount * 0.93;
                    double fuelTypeDiscount = fuelPrice - (fuelAmount * 0.08);

                    if (fuelAmount >= 20 && fuelAmount <= 25)
                    {
                        double totalPrice = fuelTypeDiscount * 0.92;
                        Console.WriteLine($"{totalPrice:f2} lv.");
                    }
                    else if (fuelAmount > 25)
                    {
                        double totalPrice = fuelTypeDiscount * 0.9;
                        Console.WriteLine($"{totalPrice:f2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"{fuelTypeDiscount:f2} lv.");
                    }
                }

                if (fuelType1 == "Gasoline")
                {
                    double fuelPrice = fuelAmount * 2.22;
                    double fuelTypeDiscount = fuelPrice - (fuelAmount * 0.18);

                    if (fuelAmount >= 20 && fuelAmount <= 25)
                    {
                        double totalPrice = fuelTypeDiscount * 0.92;
                        Console.WriteLine($"{totalPrice:f2} lv.");
                    }
                    else if (fuelAmount > 25)
                    {
                        double totalPrice = fuelTypeDiscount * 0.9;
                        Console.WriteLine($"{totalPrice:f2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"{fuelTypeDiscount:f2} lv.");
                    }
                }
                if (fuelType1 == "Diesel")
                {
                    double fuelPrice = fuelAmount * 2.33;
                    double fuelTypeDiscount = fuelPrice - (fuelAmount * 0.12);

                    if (fuelAmount >= 20 && fuelAmount <= 25)
                    {
                        double totalPrice = fuelTypeDiscount * 0.92;
                        Console.WriteLine($"{totalPrice:f2} lv.");
                    }
                    else if (fuelAmount > 25)
                    {
                        double totalPrice = fuelTypeDiscount * 0.9;
                        Console.WriteLine($"{totalPrice:f2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"{fuelTypeDiscount:f2} lv.");
                    }
                }
            }
            else
            {
                if (fuelType1 == "Gas")
                {
                    double fuelPrice = fuelAmount * 0.93;

                    if (fuelAmount >= 20 && fuelAmount <= 25)
                    {
                        double totalPrice = fuelPrice * 0.92;
                        Console.WriteLine($"{totalPrice:f2} lv.");
                    }
                    else if (fuelAmount > 25)
                    {
                        double totalPrice = fuelPrice * 0.9;
                        Console.WriteLine($"{totalPrice:f2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"{fuelPrice:f2} lv.");
                    }
                }
                if (fuelType1 == "Gasoline")
                {
                    double fuelPrice = fuelAmount * 2.22;

                    if (fuelAmount >= 20 && fuelAmount <= 25)
                    {
                        double totalPrice = fuelPrice * 0.92;
                        Console.WriteLine($"{totalPrice:f2} lv.");
                    }
                    else if (fuelAmount > 25)
                    {
                        double totalPrice = fuelPrice * 0.9;
                        Console.WriteLine($"{totalPrice:f2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"{fuelPrice:f2} lv.");
                    }
                }
                if (fuelType1 == "Diesel")
                {
                    double fuelPrice = fuelAmount * 2.33;

                    if (fuelAmount >= 20 && fuelAmount <= 25)
                    {
                        double totalPrice = fuelPrice * 0.92;
                        Console.WriteLine($"{totalPrice:f2} lv.");
                    }
                    else if (fuelAmount > 25)
                    {
                        double totalPrice = fuelPrice * 0.9;
                        Console.WriteLine($"{totalPrice:f2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"{fuelPrice:f2} lv.");
                    }
                }

            }
        }
    }
}
