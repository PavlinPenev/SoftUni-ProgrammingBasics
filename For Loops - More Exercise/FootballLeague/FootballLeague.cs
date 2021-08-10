using System;

namespace FootballLeague
{
    class FootballLeague
    {
        static void Main(string[] args)
        {
            int stadiumCapacity = int.Parse(Console.ReadLine());
            int fans = int.Parse(Console.ReadLine());
            double[] percentInSectors = { 0, 0, 0, 0 };
            for (int i = 0; i < fans; i++)
            {
                string sector = Console.ReadLine();

                switch (sector)
                {
                    case "A": percentInSectors[0]++; break;
                    case "B": percentInSectors[1]++; break;
                    case "V": percentInSectors[2]++; break;
                    case "G": percentInSectors[3]++; break;
                }
            }
            Console.WriteLine($"{percentInSectors[0] / fans * 100:f2}%");
            Console.WriteLine($"{percentInSectors[1] / fans * 100:f2}%");
            Console.WriteLine($"{percentInSectors[2] / fans * 100:f2}%");
            Console.WriteLine($"{percentInSectors[3] / fans * 100:f2}%");
            Console.WriteLine($"{(double)fans / stadiumCapacity * 100:f2}%");
        }
    }
}
