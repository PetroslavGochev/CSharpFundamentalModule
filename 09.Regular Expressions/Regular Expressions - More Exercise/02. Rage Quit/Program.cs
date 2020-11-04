using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();
            string pattern = @"(?<symbol>[^\d]+)(?<number>[\d]+)";
            MatchCollection match = Regex.Matches(input, pattern);
            StringBuilder text = new StringBuilder();
            foreach (Match data in match)
            {
                for (int i = 1; i <= int.Parse(data.Groups["number"].Value); i++)
                {
                    text.Append(data.Groups["symbol"].Value);
                }
            }
            int counter = text.ToString().Distinct().Count();
            Console.WriteLine($"Unique symbols used: {counter}");
            Console.WriteLine(text);
        }
    }
}
