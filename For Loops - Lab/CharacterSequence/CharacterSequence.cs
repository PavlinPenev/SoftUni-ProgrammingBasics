using System;

namespace CharacterSequence
{
    class CharacterSequence
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
            {
                char symbol = str[i];
                Console.WriteLine(symbol);
            }
        }
    }
}
