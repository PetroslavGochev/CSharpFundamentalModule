using System;
using System.Text.RegularExpressions;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\!(?<name>[A-Z][a-z]{2,})\!:\[(?<message>[A-Za-z]{8,})\]";
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Match match = Regex.Match(Console.ReadLine(), pattern);
                if (match.Length == 0)
                {
                    Console.WriteLine("The message is invalid");
                }
                else
                {
                    string name = match.Groups["name"].Value;
                    string message = match.Groups["message"].Value;
                    Console.Write($"{name}: ");
                    for (int j = 0; j < message.Length; j++)
                    {
                        if (j == message.Length - 1)
                        {
                            Console.Write($"{(int)message[j]}");
                        }
                        else
                        {
                            Console.Write($"{(int)message[j]} ");
                        }

                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
