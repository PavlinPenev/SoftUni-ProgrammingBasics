using System;

namespace VowelsSum
{
    class VowelsSum
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            int value = 0;
            for (int i = 0; i < str1.Length; i++)
            {

                char symbol = str1[i];
                switch (symbol)
                {
                    case 'a': value += 1; break;
                    case 'e': value += 2; break;
                    case 'i': value += 3; break;
                    case 'o': value += 4; break;
                    case 'u': value += 5; break;
                    default: value += 0; break;
                }

            }
            Console.WriteLine(value);
        }
    }
}
