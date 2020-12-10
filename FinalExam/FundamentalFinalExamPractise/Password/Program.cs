using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(.+)\>(?<first>[\d]{3})\|(?<second>[a-z]{3})\|(?<third>[A-Z]{3})\|(?<fourth>[^\<\>]{3})\<\1";
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i <= number; i++)
            {
                StringBuilder sb = new StringBuilder();
                Match match = Regex.Match(Console.ReadLine(), pattern);
                if(match.Length == 0)
                {
                    Console.WriteLine("Try another password!");
                    continue;
                }
                sb.Append(match.Groups["first"].Value);
                sb.Append(match.Groups["second"].Value);
                sb.Append(match.Groups["third"].Value);
                sb.Append(match.Groups["fourth"].Value);
                Console.WriteLine($"Password: {sb}");
            }
        }
    }
}
