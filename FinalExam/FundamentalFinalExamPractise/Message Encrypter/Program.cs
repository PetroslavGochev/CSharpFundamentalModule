using System;
using System.Text.RegularExpressions;

namespace Message_Encrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\*|@)(?<name>[A-Z][a-z]{2,})\1:\s\[(?<first>[A-Za-z])\]\|\[(?<second>[A-Za-z])\]\|\[(?<third>[A-Za-z])\]\|$";
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <=  number; i++)
            {
                Match match = Regex.Match(Console.ReadLine(), pattern);
                if(match.Length == 0)
                {
                    Console.WriteLine("Valid message not found!");
                    continue;
                }
                int first = (int)char.Parse(match.Groups["first"].Value);
                int second = (int)char.Parse(match.Groups["second"].Value);
                int third = (int)char.Parse(match.Groups["third"].Value);
                Console.WriteLine($"{match.Groups["name"].Value}: {first} {second} {third}");
            }
        }
    }
}
