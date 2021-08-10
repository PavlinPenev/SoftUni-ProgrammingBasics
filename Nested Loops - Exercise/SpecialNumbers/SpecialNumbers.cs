using System;

namespace SpecialNumbers
{
    class SpecialNumbers
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1111; i < 9999; i++)
            {
                string iString = i.ToString();
                int[] ints = {(int)char.GetNumericValue(iString[0]), (int)char.GetNumericValue(iString[1]),
                    (int)char.GetNumericValue(iString[2]), (int)char.GetNumericValue(iString[3])};
                if (ints[0] == 0 || ints[1] == 0 || ints[2] == 0 || ints[3] == 0)
                {
                    continue;
                }
                if (num % ints[0] == 0 && num % ints[1] == 0 && num % ints[2] == 0 && num % ints[3] == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
