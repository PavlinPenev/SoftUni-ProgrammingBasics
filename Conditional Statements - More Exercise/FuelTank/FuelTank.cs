using System;

namespace FuelTank
{
    class FuelTank
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double fuelInTank = double.Parse(Console.ReadLine());
            string fuelTypeDiesel = "diesel";
            string fuelTypeGasoline = "gasoline";
            string fuelTypeGas = "gas";
            string print = string.Empty;
            if (fuelType != "Diesel" && fuelType != "Gasoline" && fuelType != "Gas")
            {
                print = "Invalid fuel!";
            }
            else if (fuelType == "Diesel")
            {
                if (fuelInTank >= 25)
                {
                    print = $"You have enough {fuelTypeDiesel}.";
                }
                else
                {
                    print = $"Fill your tank with {fuelTypeDiesel}!";
                }
            }
            else if (fuelType == "Gasoline")
            {
                if (fuelInTank >= 25)
                {
                    print = $"You have enough {fuelTypeGasoline}.";
                }
                else
                {
                    print = $"Fill your tank with {fuelTypeGasoline}!";
                }
            }
            else if (fuelType == "Gas")
            {
                if (fuelInTank >= 25)
                {
                    print = $"You have enough {fuelTypeGas}.";
                }
                else
                {
                    print = $"Fill your tank with {fuelTypeGas}!";
                }
            }

            Console.WriteLine(print);
        }
    }
}
