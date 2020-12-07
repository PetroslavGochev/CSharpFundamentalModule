using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Ad_Astra
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(#|\|)(?<name>[A-Za-z\s]+)\1(?<date>[\d]{2}\/[\d]{2}\/[\d]{2})\1(?<calories>[\d]+)\1";
            string input = Console.ReadLine();
            MatchCollection match = Regex.Matches(input, pattern);
            int totalCalories = 0;
            foreach (Match item in match)
            {
                totalCalories += int.Parse(item.Groups["calories"].Value.ToString());
            }
            int days = totalCalories / 2000;
            Console.WriteLine($"You have food to last you for: {days} days!");
            foreach (Match item in match)
            {
                Console.WriteLine($"Item: {item.Groups["name"].Value}, Best before: {item.Groups["date"].Value}, Nutrition: {item.Groups["calories"].Value}");
            }

        }
    }
}
