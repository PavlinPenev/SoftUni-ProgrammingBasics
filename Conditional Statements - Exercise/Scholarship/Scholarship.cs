using System;

namespace Scholarship
{
    class Scholarship
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double GPA = double.Parse(Console.ReadLine());
            double minWage = double.Parse(Console.ReadLine());

            double socialScholarship = minWage * 0.35;
            double excellenceScholarship = GPA * 25;
            string print = string.Empty;
            if (income < minWage && GPA >= 4.50 && GPA < 5.50)
            {
                print = $"You get a Social scholarship {Math.Floor(socialScholarship)} BGN";
            }
            else if (income < minWage && GPA >= 5.50)
            {
                if (socialScholarship > excellenceScholarship)
                {
                    print = $"You get a Social scholarship {Math.Floor(socialScholarship)} BGN";
                }
                else if (socialScholarship < excellenceScholarship)
                {
                    print = $"You get a scholarship for excellent results {Math.Floor(excellenceScholarship)} BGN";
                }
                else
                {
                    print = $"You get a scholarship for excellent results {Math.Floor(excellenceScholarship)} BGN";
                }
            }
            else if (GPA >= 5.50)
            {
                print = $"You get a scholarship for excellent results {Math.Floor(excellenceScholarship)} BGN";
            }

            else
            {
                print = "You cannot get a scholarship!";
            }

            Console.WriteLine(print);
        }
    }
}
