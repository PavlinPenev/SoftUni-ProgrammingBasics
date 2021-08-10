using System;

namespace Password
{
    class Password
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            string passwordCheck = string.Empty;
            while (passwordCheck != password)
            {
                passwordCheck = Console.ReadLine();
                if (passwordCheck == password)
                {
                    Console.WriteLine($"Welcome {username}!");
                }
            }
        }
    }
}
