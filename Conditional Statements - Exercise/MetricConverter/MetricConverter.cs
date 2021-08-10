using System;

namespace MetricConverter
{
    class MetricConverter
    {
        static void Main(string[] args)
        {
            double unitDistanceMeasure = double.Parse(Console.ReadLine());
            string inputUnitMeasure = Console.ReadLine();
            string outputUnitMeasure = Console.ReadLine();

            switch (inputUnitMeasure)
            {
                case "m":
                    if (outputUnitMeasure == "m")
                    {
                        Console.WriteLine($"{unitDistanceMeasure:f3}");
                    }
                    else if (outputUnitMeasure == "cm")
                    {
                        double finalMeasure = unitDistanceMeasure * 100;
                        Console.WriteLine($"{finalMeasure:f3}");
                    }
                    else if (outputUnitMeasure == "mm")
                    {
                        double finalMeasure = unitDistanceMeasure * 1000;
                        Console.WriteLine($"{finalMeasure:f3}");
                    }
                    break;
                case "cm":
                    if (outputUnitMeasure == "m")
                    {
                        double finalMeasure = unitDistanceMeasure / 100;
                        Console.WriteLine($"{finalMeasure:f3}");
                    }
                    else if (outputUnitMeasure == "cm")
                    {

                        Console.WriteLine($"{outputUnitMeasure:f3}");
                    }
                    else if (outputUnitMeasure == "mm")
                    {
                        double finalMeasure = unitDistanceMeasure * 10;
                        Console.WriteLine($"{finalMeasure:f3}");
                    }
                    break;
                case "mm":
                    if (outputUnitMeasure == "m")
                    {
                        double finalMeasure = unitDistanceMeasure / 1000;
                        Console.WriteLine($"{finalMeasure:f3}");
                    }
                    else if (outputUnitMeasure == "cm")
                    {
                        double finalMeasure = unitDistanceMeasure / 10;
                        Console.WriteLine($"{finalMeasure:f3}");
                    }
                    else if (outputUnitMeasure == "mm")
                    {
                        Console.WriteLine($"{outputUnitMeasure:f3}");
                    }
                    break;
            }
        }
    }
}
