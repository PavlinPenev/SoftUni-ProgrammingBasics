using System;

namespace CinemaTicket
{
    class CinemaTicket
    {
        static void Main(string[] args)
        {
            string day2 = Console.ReadLine();

            switch (day2)
            {
                case "Monday":
                case "Tuesday":
                case "Friday":
                    Console.WriteLine(12);
                    break;
                case "Wednesday":
                case "Thursday":
                    Console.WriteLine(14);
                    break;
                case "Saturday":
                case "Sunday":
                    Console.WriteLine(16);
                    break;
            }
        }
    }
}
