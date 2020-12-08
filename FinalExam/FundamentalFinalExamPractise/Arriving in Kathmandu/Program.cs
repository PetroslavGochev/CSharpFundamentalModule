using System;
using System.Text.RegularExpressions;

namespace Arriving_in_Kathmandu
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^^(?<name>[A-Za-z!@#$?]+)=(?<length>[\d]+)<<(?<coord>.+)";
            string input = string.Empty;
            while((input = Console.ReadLine()) != "Last note")
            {
                Match match = Regex.Match(input, pattern);
                if(match.Length == 0)
                {
                    Console.WriteLine("Nothing found!");
                    continue;
                }
                string name = match.Groups["name"].Value;
                int lenthg = int.Parse(match.Groups["length"].Value);
                int coordLength = match.Groups["coord"].Length;
                if ( lenthg == coordLength)
                {
                    Console.WriteLine($"Coordinates found! {name} -> {match.Groups["coord"].Value}");
                }
                else
                {
                    Console.WriteLine("Nothing found!");
                }
            }
        }
    }
}
