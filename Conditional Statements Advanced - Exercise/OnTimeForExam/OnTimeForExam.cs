using System;

namespace OnTimeForExam
{
    class OnTimeForExam
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int studentHour = int.Parse(Console.ReadLine());
            int studentMinute = int.Parse(Console.ReadLine());

            //converting the time of the exam and the time the student arrived to the exam in mins
            int examTimeMins = examHour * 60 + examMinute;
            int studentTimeMins = studentHour * 60 + studentMinute;
            int diffInTimes = Math.Abs(examTimeMins - studentTimeMins);//absolute value of the time student got early/late to the exam

            //On time
            if (examTimeMins == studentTimeMins || (examTimeMins > studentTimeMins && diffInTimes <= 30))
            {
                if (diffInTimes != 0)//if student got to the exam exactly mins earlier (max 30)
                {
                    Console.WriteLine("On Time");
                    Console.WriteLine($"{diffInTimes} minutes before the start");//we have to print this just for that case only
                }
                else
                {
                    Console.WriteLine("On Time");
                }
            }
            //Early
            else if (examTimeMins > studentTimeMins && diffInTimes > 30)
            {

                if (diffInTimes < 60)//if student arrived less than an hour earlier 
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{diffInTimes} minutes before the start");
                }
                else
                {
                    int minutes = diffInTimes % 60;                 //if student arrived more than an hour earlier
                    diffInTimes /= 60;                              //we convert the minutes he got early in hours and minutes


                    Console.WriteLine("Early");
                    Console.WriteLine($"{diffInTimes}:{minutes:d2} hours before the start");
                }
            }
            //Late
            else
            {
                if (diffInTimes < 60) //if student arrived less than an hour later
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{diffInTimes} minutes after the start");
                }
                else
                {
                    int minutes = diffInTimes % 60;                 //if student arrived more than an hour later
                    diffInTimes /= 60;                              //we convert the minutes he got late in hours and minutes

                    Console.WriteLine("Late");
                    Console.WriteLine($"{diffInTimes}:{minutes:d2} hours after the start");
                }
            }
        }
    }
}
