using System;

namespace PasswordGenerator
{
    class PasswordGenerator
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int i = 1; i < t; i++)
            {
                for (int j = 1; j < t; j++)
                {
                    for (int k = 97; k < 97 + l; k++)
                    {
                        for (int o = 97; o < 97 + l; o++)
                        {
                            for (int m = i; m <= t; m++)
                            {
                                if (m > i && m > j)
                                {
                                    Console.Write($"{i}{j}{(char)k}{(char)o}{m} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
