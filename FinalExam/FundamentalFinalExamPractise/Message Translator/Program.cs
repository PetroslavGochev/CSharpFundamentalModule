using System;
using System.Text.RegularExpressions;

namespace Message_Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"!(?<command>[A-z][a-z]{2,})!:\[(?<message>[A-Za-z]{8,})]";
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Match match = Regex.Match(Console.ReadLine(), pattern);
                if(match.Length == 0)
                {
                    Console.WriteLine("The message is invalid");
                    continue;
                }
                Console.Write($"{match.Groups["command"].Value}: ");
                foreach (var character in match.Groups["message"].Value)
                {
                    Console.Write($"{(int)character} ");
                }
                Console.WriteLine();
            }
        }
    }
}
