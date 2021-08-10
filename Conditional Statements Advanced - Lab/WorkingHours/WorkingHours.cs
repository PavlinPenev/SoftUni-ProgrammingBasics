using System;

namespace WorkingHours
{
    class WorkingHours
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string day1 = Console.ReadLine();
            Console.WriteLine(hour >= 10 && hour <= 18 && (day1 == "Monday" || day1 == "Tuesday" || day1 == "Wednesday" || day1 == "Thursday" || day1 == "Friday" || day1 == "Saturday") ? "open" : "closed");
        }
    }
}
