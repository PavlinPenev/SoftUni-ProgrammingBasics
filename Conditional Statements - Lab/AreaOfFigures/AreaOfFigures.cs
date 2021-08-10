using System;

namespace AreaOfFigures
{
    class AreaOfFigures
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine();
            double area = 0, sideA, sideB, radius, heightA;
            switch (shape)
            {
                case "square":
                    sideA = double.Parse(Console.ReadLine());
                    area = sideA * sideA;
                    break;
                case "rectangle":
                    sideA = double.Parse(Console.ReadLine()); 
                    sideB = double.Parse(Console.ReadLine());
                    area = sideA * sideB;
                    break;
                case "circle":
                    radius = double.Parse(Console.ReadLine());
                    area = Math.PI * (radius * radius);
                    break;
                case "triangle":
                    sideA = double.Parse(Console.ReadLine());
                    heightA = double.Parse(Console.ReadLine());
                    area = (sideA * heightA) / 2;
                    break;
            }
            Console.WriteLine($"{area:f3}");
        }
    }
}
