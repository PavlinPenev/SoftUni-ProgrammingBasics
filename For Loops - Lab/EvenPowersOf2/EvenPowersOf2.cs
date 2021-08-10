using System;

namespace EvenPowersOf2
{
    class EvenPowersOf2
    {
        static void Main(string[] args)
        {
            int num2 = int.Parse(Console.ReadLine());
            for (int i = 0; i <= num2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(Math.Pow(2, i));
                }
            }
        }
    }
}
