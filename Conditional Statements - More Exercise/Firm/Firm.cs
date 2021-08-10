using System;

namespace Firm
{
    class Firm
    {
        static void Main(string[] args)
        {
            int hoursNeeded = int.Parse(Console.ReadLine());
            int daysWeHave = int.Parse(Console.ReadLine());
            int workers1 = int.Parse(Console.ReadLine());

            double hoursWorking = (daysWeHave - (daysWeHave * 0.10)) * 8;

            double totalOvertime = (2 * daysWeHave) * workers1;
            double totalWorkingTime = Math.Floor(totalOvertime + hoursWorking);


            if (totalWorkingTime < hoursNeeded)
            {
                double diffInWorkingTime = Math.Abs(totalWorkingTime - hoursNeeded);
                Console.WriteLine($"Not enough time!{diffInWorkingTime} hours needed.");
            }
            else
            {
                double diffInWorkingTime = Math.Abs(totalWorkingTime - hoursNeeded);
                Console.WriteLine($"Yes!{diffInWorkingTime} hours left.");
            }
        }
    }
}
