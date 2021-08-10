using System;

namespace ExcursionSale
{
    class ExcursionSale
    {
        static void Main(string[] args)
        {
            int seaExcursions = int.Parse(Console.ReadLine());    //vouchers for sea trips
            int mountExcursions = int.Parse(Console.ReadLine());  //vouchers for mountain trips

            double seaExcPrice = 680;
            double mountExcPrice = 499; //prices for both type of trips
            double earnings = 0; //variable summing all the vouchers sold
            while (true)
            {
                string str = Console.ReadLine(); //typing type of voucher sold

                switch (str)
                {
                    case "sea":                     //operations executed when sea trip voucher is sold
                        if (seaExcursions <= 0)
                        {
                            seaExcPrice = 0;
                        }
                        earnings += seaExcPrice;
                        seaExcursions--;
                        break;
                    case "mountain":                //operations executed when mountain trip voucher is sold
                        if (mountExcursions <= 0)
                        {
                            mountExcPrice = 0;
                        }
                        earnings += mountExcPrice;
                        mountExcursions--;
                        break;
                }
                if (seaExcursions <= 0 && mountExcursions <= 0 || str == "Stop")  // <= because customers may try to buy a voucher of 
                {                                                             // already sold out voucher but there are still
                    break;                                                    // available vouchers of the other type
                }                                                             // so when the second type voucher is sold as well-break;
            }
            if (seaExcursions <= 0 && mountExcursions <= 0) // in case vouchers are all sold out
            {
                Console.WriteLine("Good job! Everything is sold.");
            }
            Console.WriteLine($"Profit: {earnings} leva.");
        }
    }
}
