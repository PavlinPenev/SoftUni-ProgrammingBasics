using System;
namespace Moving
{
    class Moving
    {
        static void Main(string[] args)
        {
            int widthFree = int.Parse(Console.ReadLine());
            int lengthFree = int.Parse(Console.ReadLine());
            int heightFree = int.Parse(Console.ReadLine());

            double freeSpace = widthFree * lengthFree * heightFree;
            string boxesCount = Console.ReadLine();
            while (freeSpace > 0 && boxesCount != "Done")
            {
                double boxesCountNum = double.Parse(boxesCount);
                freeSpace -= boxesCountNum;
                boxesCount = Console.ReadLine();
            }
            Console.WriteLine(freeSpace <= 0 ? $"No more free space! You need {Math.Abs(freeSpace)} Cubic meters more." : $"{freeSpace} Cubic meters left.");
        }
    }
}
