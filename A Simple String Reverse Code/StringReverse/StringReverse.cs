using System;

namespace StringReverse
{
    class StringReverse
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char[] strChar = new char[1000];

            int end = str.Length - 1;
            for (int i = 0; i < str.Length; i++)
            {
                strChar[i] = str[end];
                end--;
            }
            Console.WriteLine(strChar);
        }
    }
}
