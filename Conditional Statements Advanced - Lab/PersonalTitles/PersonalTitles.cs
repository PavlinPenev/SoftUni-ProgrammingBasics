using System;

namespace PersonalTitles
{
    class PersonalTitles
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string sex = Console.ReadLine();

            switch (sex)
            {
                case "m":
                    Console.WriteLine(age < 16 ? "Master" : "Mr.");
                    break;
                case "f":
                    Console.WriteLine(age < 16 ? "Miss" : "Ms.");
                    break;
            }
        }
    }
}
