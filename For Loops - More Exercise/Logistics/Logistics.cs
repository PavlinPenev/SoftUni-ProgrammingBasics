using System;

namespace Logistics
{
    class Logistics
    {
        static void Main(string[] args)
        {
            int deliveryCounts = int.Parse(Console.ReadLine());
            double[] tonsCategory = { 0, 0, 0 };
            double[] percents = { 0, 0, 0 };


            for (int i = 0; i < deliveryCounts; i++)
            {
                double deliveryWeight = double.Parse(Console.ReadLine());
                if (deliveryWeight <= 3)
                {
                    tonsCategory[0] += deliveryWeight;         //deliveries by bus/200lv per ton
                }
                else if (deliveryWeight <= 11)
                {
                    tonsCategory[1] += deliveryWeight;         //deliveries with a truck/175lv per ton
                }
                else
                {
                    tonsCategory[2] += deliveryWeight;         //deliveries by train/120lv per ton
                }
            }
            double deliveriesCount = tonsCategory[0] + tonsCategory[1] + tonsCategory[2];
            double averagePriceAllDeliveries = (tonsCategory[0] * 200 + tonsCategory[1] * 175 + tonsCategory[2] * 120) / deliveriesCount;
            percents[0] = tonsCategory[0] / deliveriesCount * 100;
            percents[1] = tonsCategory[1] / deliveriesCount * 100;
            percents[2] = tonsCategory[2] / deliveriesCount * 100;
            Console.WriteLine($"{averagePriceAllDeliveries:f2}");
            Console.WriteLine($"{percents[0]:f2}%");
            Console.WriteLine($"{percents[1]:f2}%");
            Console.WriteLine($"{percents[2]:f2}%");
        }
    }
}
