using System;

namespace Numbers1ToNStep3
{
    class Numbers1ToNStep3
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num1; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
