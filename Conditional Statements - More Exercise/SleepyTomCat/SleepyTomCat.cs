using System;

namespace SleepyTomCat
{
    class SleepyTomCat
    {
        static void Main(string[] args)
        {
            int daysOff = int.Parse(Console.ReadLine());

            int playDaysOff = daysOff * 127;
            int playWorkDays = (365 - daysOff) * 63;

            int annualPlayTime = playDaysOff + playWorkDays;
            int diffAnnualNorm = Math.Abs(30000 - annualPlayTime);
            int hours = diffAnnualNorm / 60;
            int minutes = diffAnnualNorm - hours * 60;
            Console.WriteLine(annualPlayTime > 30000 ? $"Tom will run away\n{hours} hours and {minutes} minutes more for play" : $"Tom sleeps well\n{hours} hours and {minutes} minutes less for play");
        }
    }
}
