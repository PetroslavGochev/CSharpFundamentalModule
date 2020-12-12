using System;
using System.Text.RegularExpressions;

namespace Boss_Rush
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\|(?<boss>[A-Z]{4,})\|:#(?<title>[A-Za-z]+\s[A-Za-z]+)#";
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Match match = Regex.Match(Console.ReadLine(), pattern);
                if (match.Length == 0)
                {
                    Console.WriteLine("Access denied!");
                }
                else
                {
                    string name = match.Groups["boss"].Value;
                    string title = match.Groups["title"].Value;
                    Console.WriteLine($"{name}, The {title}");
                    Console.WriteLine($">> Strength: {name.Length}");
                    Console.WriteLine($">> Armour: {title.Length}");
                }
            }
        }
    }
}
