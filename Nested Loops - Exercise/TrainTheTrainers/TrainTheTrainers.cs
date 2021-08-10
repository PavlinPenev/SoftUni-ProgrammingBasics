using System;

namespace TrainTheTrainers
{
    class TrainTheTrainers
    {
        static void Main(string[] args)
        {
            bool isTrue1 = false;
            int jouryCount = int.Parse(Console.ReadLine());
            double gradesSum = 0, gradesSumAll = 0;
            int counter = 0;

            while (isTrue1 != true)
            {
                string presentation = Console.ReadLine();
                if (presentation == "Finish")
                {
                    isTrue1 = true;
                    continue;
                }

                for (int i = 0; i < jouryCount; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    gradesSum += grade;
                    gradesSumAll += grade;
                    counter++;
                }
                Console.WriteLine($"{presentation} - {((double)gradesSum / jouryCount):f2}.");
                gradesSum = 0;
            }
            Console.WriteLine($"Student's final assessment is {((double)gradesSumAll / counter):f2}.");
        }
    }
}
