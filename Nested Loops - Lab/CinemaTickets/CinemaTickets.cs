using System;

namespace CinemaTickets
{
    class CinemaTickets
    {
        static void Main(string[] args)
        {
            double counterStandard = 0;
            double counterStudent = 0;
            double counterKid = 0;
            double counterStandardMovie = 0;
            double counterStudentMovie = 0;
            double counterKidMovie = 0;
            double freePlaces = 1;
            string movie = Console.ReadLine();
            while (movie != "Finish")
            {
                freePlaces = double.Parse(Console.ReadLine());
                double fullCapacity = freePlaces;

                while (freePlaces != 0 && freePlaces > 0)
                {
                    string ticketType = Console.ReadLine();
                    if (ticketType == "End")
                    {
                        break;
                    }
                    switch (ticketType)
                    {
                        case "standard": freePlaces--; counterStandard++; counterStandardMovie++; break;
                        case "student": freePlaces--; counterStudent++; counterStudentMovie++; break;
                        case "kid": freePlaces--; counterKid++; counterKidMovie++; break;
                    }
                }
                Console.WriteLine($"{movie} - {((counterKidMovie + counterStandardMovie + counterStudentMovie) / fullCapacity * 100):f2}% full.");

                counterStandardMovie = 0;
                counterStudentMovie = 0;
                counterKidMovie = 0;
                movie = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {counterStudent + counterStandard + counterKid}");
            Console.WriteLine($"{(counterStudent / (counterStudent + counterStandard + counterKid) * 100):f2}% student tickets.");
            Console.WriteLine($"{(counterStandard / (counterStudent + counterStandard + counterKid) * 100):f2}% standard tickets.");
            Console.WriteLine($"{(counterKid / (counterStudent + counterStandard + counterKid) * 100):f2}% kids tickets.");
        }
    }
}
