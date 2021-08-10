using System;

namespace StreamOfLetters
{
    class StreamOfLetters
    {
        static void Main(string[] args)
        {
            string input1 = "";
            string secretCommand = "";
            string word = "";
            string printWords = "";

            while (true)
            {

                input1 = Console.ReadLine();

                if (input1 == "End")
                {
                    break;
                }
                char letters = char.Parse(input1);
                if ((letters >= 65 && letters <= 90) || (letters >= 97 && letters <= 122))
                {
                    if (letters == 'c' && !(secretCommand.Contains("c")))
                    {
                        secretCommand += char.ToString(letters);
                    }
                    else if (letters == 'o' && !(secretCommand.Contains("o")))
                    {
                        secretCommand += char.ToString(letters);
                    }
                    else if (letters == 'n' && !(secretCommand.Contains("n")))
                    {
                        secretCommand += char.ToString(letters);
                    }
                    else
                    {
                        word += char.ToString(letters);
                    }
                    if (secretCommand.Contains("c") && secretCommand.Contains("o") && secretCommand.Contains("n"))
                    {
                        word += " ";
                        secretCommand = "";
                        printWords += word;
                        word = "";
                    }
                }

            }
            Console.WriteLine(printWords);
        }
    }
}
