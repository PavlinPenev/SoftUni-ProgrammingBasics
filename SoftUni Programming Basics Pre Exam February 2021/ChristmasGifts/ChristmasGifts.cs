using System;

namespace ChristmasGifts
{
    class ChristmasGifts
    {
        static void Main(string[] args)
        {
            bool isTrue = false;
            double moneySweaters = 0;
            double moneyToys = 0;
            int adultsCounter = 0;
            int kidsCounter = 0;

            while (isTrue == false)
            {
                string ageFamilyMember = Console.ReadLine();
                if (ageFamilyMember == "Christmas")
                {
                    isTrue = true;
                    continue;
                }
                int ageFamMemInt = int.Parse(ageFamilyMember);
                if (ageFamMemInt > 16)
                {
                    adultsCounter++;
                    moneySweaters += 15;
                }
                else
                {
                    kidsCounter++;
                    moneyToys += 5;
                }
            }
            Console.WriteLine($"Number of adults: {adultsCounter}");
            Console.WriteLine($"Number of kids: {kidsCounter}");
            Console.WriteLine($"Money for toys: {moneyToys}");
            Console.WriteLine($"Money for sweaters: {moneySweaters}");
        }
    }
}
