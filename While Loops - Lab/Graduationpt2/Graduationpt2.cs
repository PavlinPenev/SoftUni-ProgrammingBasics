using System;

namespace Graduationpt2
{
    class Graduationpt2
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int gradeClass = 1;
            double averageGrade = 0;
            int repeatsClass = 0;

            while (gradeClass <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                averageGrade += grade;
                if (grade < 4.00)
                {
                    repeatsClass++;
                    if (repeatsClass > 1)
                    {
                        Console.WriteLine($"{studentName} has been excluded at {gradeClass} grade");
                        return;
                    }
                    gradeClass--;
                }
                gradeClass++;
            }
            Console.WriteLine($"{studentName} graduated. Average grade: {(averageGrade / 12):f2}");
        }
    }
}
