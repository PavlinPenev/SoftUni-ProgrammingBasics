using System;

namespace Bus
{
    class Bus
    {
        static void Main(string[] args)
        {
            int passengersTakeOff = int.Parse(Console.ReadLine());
            int busStopsCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= busStopsCount; i++)
            {
                passengersTakeOff -= int.Parse(Console.ReadLine());
                passengersTakeOff += int.Parse(Console.ReadLine());
                passengersTakeOff += i % 2 == 1 ? 2 : -2;
            }
            Console.WriteLine($"The final number of passengers is : {passengersTakeOff}");
        }
    }
}
