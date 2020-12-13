using System;
using System.Text.RegularExpressions;

namespace Message_Decrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^(\$|%)(?<name>[A-Z][a-z]{2,})\1:\s\[(?<first>[\d]+)\]\|\[(?<second>[\d]+)\]\|\[(?<third>[\d]+)\]\|$";
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Match match = Regex.Match(Console.ReadLine(), pattern);
                if (match.Length == 0)
                {
                    Console.WriteLine("Valid message not found!");
                    continue;
                }
                char first = (char)int.Parse(match.Groups["first"].Value);
                char second = (char)int.Parse(match.Groups["second"].Value);
                char third = (char)int.Parse(match.Groups["third"].Value);
                Console.WriteLine($"{match.Groups["name"].Value}: {first}{second}{third}");
            }
        }
    }
}

