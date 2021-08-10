using System;

namespace Time15Minutes
{
    class Time15Minutes
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes1 = int.Parse(Console.ReadLine());
            string print = string.Empty;
            if (minutes1 < 45)
            {
                print = $"{hours}:{minutes1 + 15:d2}";
            }
            else if (hours != 23 && minutes1 >= 45)
            {
                print = $"{hours + 1}:{((minutes1 + 15) - 60):d2}";
            }
            else if (hours == 23 && minutes1 >= 45)
            {
                hours = 0;
                print = $"{hours}:{((minutes1 + 15) - 60):d2}";
            }

            Console.WriteLine(print);
        }
    }
}
