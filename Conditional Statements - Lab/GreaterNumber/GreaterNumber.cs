using System;

namespace GreaterNumber
{
    class GreaterNumber
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine(firstNumber > secondNumber ? firstNumber : secondNumber);
        }
    }
}
