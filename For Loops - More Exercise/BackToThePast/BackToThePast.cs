using System;

namespace BackToThePast
{
    class BackToThePast
    {
        static void Main(string[] args)
        {
            double inheritance = double.Parse(Console.ReadLine());
            int lastYear = int.Parse(Console.ReadLine());

            for (int i = 0; i <= lastYear - 1800; i++)
            {
                inheritance -= i % 2 == 0 ? 12000 : 12000 + 50 * (18 + i);
            }
            Console.WriteLine(inheritance >= 0 ? $"Yes! He will live a carefree life and will have {inheritance:f2} dollars left." : $"He will need {Math.Abs(inheritance):f2} dollars to survive.");
        }
    }
}
