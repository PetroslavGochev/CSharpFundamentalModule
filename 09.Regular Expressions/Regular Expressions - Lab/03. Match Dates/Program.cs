using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b([\d]{2})([\/|\-|\.])([A-Z][a-z]{2})\2([\d]{4})\b";
            string input = Console.ReadLine();
            MatchCollection matchDates = Regex.Matches(input, pattern);
            foreach (Match dates  in matchDates)
            {
                Console.WriteLine($"Day: {dates.Groups[1]}, Month: {dates.Groups[3]}, Year: {dates.Groups[4]}");
            }
        }
    }
}
