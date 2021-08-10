using System;

namespace Cake
{
    class Cake
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());

            int cakeArea = width * length;
            while (cakeArea > 0)
            {
                string piecesCake = Console.ReadLine();
                if (piecesCake == "STOP")
                {
                    break;
                }
                int piecesOfCake = int.Parse(piecesCake);
                cakeArea -= piecesOfCake;
            }
            Console.WriteLine(cakeArea <= 0 ? $"No more cake left! You need {Math.Abs(cakeArea)} pieces more." : $"{cakeArea} pieces are left.");
        }
    }
}
