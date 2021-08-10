using System;

namespace Building
{
    class Building
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            for (int i = floors; i >= 1; i--)
            {
                for (int u = 0; u < rooms; u++)
                {
                    if (floors == 1 || i == floors)
                    {
                        Console.Write($"L{i}{u} ");
                    }
                    else if (i % 2 == 0)
                    {
                        Console.Write($"O{i}{u} ");
                    }
                    else if (i % 2 == 1)
                    {
                        Console.Write($"A{i}{u} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
