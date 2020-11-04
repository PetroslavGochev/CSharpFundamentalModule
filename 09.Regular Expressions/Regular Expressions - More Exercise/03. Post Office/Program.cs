using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03._Post_Office
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstPattern = @"(\$[A-Z]+\$|#[A-Z]+#|\*[A-Z]+\*|&[A-Z]+&|%[A-Z]+%)";
            string secondPattern = @"([\d]{2}:[\d]{2})";
            string thirdPattern = @"([A-Z][a-z]+)";

            string[] input = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            StringBuilder result = new StringBuilder();
            Match firstPart = Regex.Match(input[0], firstPattern);
            MatchCollection secondPart = Regex.Matches(input[1], secondPattern);
            MatchCollection thirdPart = Regex.Matches(input[2], thirdPattern);
            foreach (Match item in secondPart)
            {
                //int[] second = item.Value
                //    .Split(":",StringSplitOptions.RemoveEmptyEntries)
                //    .Select(int.Parse)
                //    .ToArray();
                for (int i = 1; i < firstPart.Length-2; i++)
                {
                    if (item.Value[0] == (char)firstPart.Value[i])
                    {
                        foreach (Match word in thirdPart)
                        {
                            if (word.Length == item.Value[1] && word.Value[0] == firstPart.Value[i])
                            {
                                result.AppendLine(word.Value);
                            }
                        }
                    }
                }
               
            }
            Console.WriteLine(result.ToString().Trim());
            
        }
    }
}
