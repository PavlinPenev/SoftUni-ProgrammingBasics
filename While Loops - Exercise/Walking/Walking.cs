using System;

namespace Walking
{
    class Walking
    {
        static void Main(string[] args)
        {
            int totalSteps = 0;
            while (totalSteps < 10000)
            {
                string stepsPerGoingOut = Console.ReadLine();
                if (stepsPerGoingOut == "Going home")
                {
                    totalSteps += int.Parse(Console.ReadLine());
                    break;
                }
                int steps = int.Parse(stepsPerGoingOut);
                totalSteps += steps;
            }
            Console.WriteLine(totalSteps < 10000 ? $"{10000 - totalSteps} more steps to reach goal." : $"Goal reached! Good job!\n{totalSteps - 10000} steps over the goal!");
        }
    }
}
