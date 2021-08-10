using System;

namespace Histogram
{
    class Histogram
    {
        static void Main(string[] args)
        {
            int input2 = int.Parse(Console.ReadLine());
            double[] counter = { 0, 0, 0, 0, 0 };

            //counter[0] - < 200, counter[1] - >= 200 < 400, counter[2] - >=400 <600, counter[3] - >=600 < 800, counter[4] - >=800 
            for (int i = 0; i < input2; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 200)
                {
                    counter[0]++;
                }
                else if (number < 400)
                {
                    counter[1]++;
                }
                else if (number < 600)
                {
                    counter[2]++;
                }
                else if (number < 800)
                {
                    counter[3]++;
                }
                else
                {
                    counter[4]++;
                }
            }
            Console.WriteLine($"{(counter[0] / input2 * 100):f2}%");
            Console.WriteLine($"{(counter[1] / input2 * 100):f2}%");
            Console.WriteLine($"{(counter[2] / input2 * 100):f2}%");
            Console.WriteLine($"{(counter[3] / input2 * 100):f2}%");
            Console.WriteLine($"{(counter[4] / input2 * 100):f2}%");
        }
    }
}
