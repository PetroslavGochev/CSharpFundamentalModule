using System;
using System.Linq;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userName = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            foreach (var user in userName)
            {
                bool flag = true;
                if (user.Length > 3 && user.Length < 16)
                {
                    foreach (var symbol in user)
                    {
                        if (symbol >= 'A' && symbol <= 'Z' || symbol >= 'a' && symbol <= 'z' || symbol >= '0' && symbol <= '9' || symbol == '_' || symbol == '-')
                        {
                            continue;
                        }
                        else
                        {
                            flag = false;
                            break;
                        }

                    }
                }
                else
                {
                    flag = false;
                }
                if (flag)
                {
                    Console.WriteLine(user);
                }
            }
        }
    }
}
