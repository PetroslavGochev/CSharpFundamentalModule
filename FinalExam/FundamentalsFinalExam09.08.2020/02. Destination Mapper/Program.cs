using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(=[A-Z][A-Za-z]{2,}=|\/[A-Z][A-Za-z]{2,}\/)";
            string destinationPattern = @"[^=\/]+";
            string text = Console.ReadLine();
            int numberOfDigit = 0;
            MatchCollection match = Regex.Matches(text, pattern);
            List<string> destination = new List<string>();
            foreach (Match item in match)
            {
                Match dest = Regex.Match(item.Value, destinationPattern);
                numberOfDigit += dest.Length;
                destination.Add(dest.Value);         
            }
            Console.WriteLine($"Destinations: {string.Join(", ", destination)}");
            Console.WriteLine($"Travel Points: {numberOfDigit}");

        }
    }
}
