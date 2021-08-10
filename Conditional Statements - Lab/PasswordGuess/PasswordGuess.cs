using System;

namespace PasswordGuess
{
    class PasswordGuess
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            Console.WriteLine(password == "s3cr3t!P@ssw0rd" ? "Welcome" : "Wrong password!");
        }
    }
}
