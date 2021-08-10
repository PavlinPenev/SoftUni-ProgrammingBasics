using System;

namespace ExcursionGames
{
    class ExcursionGames
    {
        static void Main(string[] args)
        {
            int playersCount = int.Parse(Console.ReadLine());
            int sumOfPlayNum = 0;
            int winCounter = 0;
            int loseCounter = 0;
            int currWin = 0;
            int currLose = 0;
            int winCounterTotal = 0;
            int loseCounterTotal = 0;

            for (int i = 1; i <= playersCount; i++)
            {
                string destination = Console.ReadLine();
                for (int j = 0; j < destination.Length; j++)
                {
                    loseCounter = 0;
                    winCounter = 0;
                    currWin = 0;
                    currLose = 0;

                    int input = int.Parse(Console.ReadLine());
                    sumOfPlayNum += input;

                    if (sumOfPlayNum % destination.Length == 0)
                    {
                        currLose = 0;
                        currWin++;
                    }
                    else
                    {
                        currWin = 0;
                        currLose++;
                    }
                }
                if (currWin > 0)
                {
                    Console.WriteLine("Win");
                    winCounter++;
                    winCounterTotal++;
                }
                else if (currLose > 0)
                {
                    Console.WriteLine("Lost");
                    loseCounter++;
                    loseCounterTotal++;
                }
                sumOfPlayNum = 0;
            }
            Console.WriteLine($"Win: {((double)winCounterTotal / playersCount) * 100:f2}%");
            Console.WriteLine($"Lost: {((double)loseCounterTotal / playersCount) * 100:f2}%");
        }
    }
}
