using System;

namespace BarcodeGenerator
{
    class BarcodeGenerator
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            char[] input1Char = input1.ToCharArray();
            int[] input1Int = Array.ConvertAll(input1Char, c => (int)char.GetNumericValue(c));
            string input2 = Console.ReadLine();
            char[] input2Char = input2.ToCharArray();
            int[] input2Int = Array.ConvertAll(input2Char, c => (int)char.GetNumericValue(c));
 
            for (int i = input1Int[0]; i <= input2Int[0] ; i++)
            {
                for (int u = input1Int[1]; u <= input2Int[1]; u++)
                {
                    for (int e = input1Int[2]; e <= input2Int[2]; e++)
                    {
                        for (int a = input1Int[3]; a <= input2Int[3]; a++)
                        {
                            if (i % 2 != 0 && u % 2 != 0 && e % 2 != 0 && a % 2 != 0)
                            {
                                Console.Write($"{i}{u}{e}{a} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
