using System;

namespace Grades
{
    class Grades
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            double[] counter = { 0, 0, 0, 0 };
            double averageGradeSuccess = 0;

            for (int i = 0; i < students; i++)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade <= 2.99)
                {
                    counter[0]++; averageGradeSuccess += grade;
                }
                else if (grade <= 3.99)
                {
                    counter[1]++; averageGradeSuccess += grade;
                }
                else if (grade <= 4.99)
                {
                    counter[2]++; averageGradeSuccess += grade;
                }
                else
                {
                    counter[3]++; averageGradeSuccess += grade;
                }
            }
            averageGradeSuccess /= students;
            Console.WriteLine($"Top students: {(counter[3] / students * 100):f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {(counter[2] / students * 100):f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {(counter[1] / students * 100):f2}%");
            Console.WriteLine($"Fail: {(counter[0] / students * 100):f2}%");
            Console.WriteLine($"Average: {averageGradeSuccess:f2}");
        }
    }
}
