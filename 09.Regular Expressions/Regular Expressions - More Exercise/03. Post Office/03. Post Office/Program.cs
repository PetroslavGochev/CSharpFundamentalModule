using System;
using System.Collections.Generic;
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
            //string thirdPattern = @"\b([A-Z][\S]+)";

            string[] input = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            List<string> words = input[2].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            foreach (var item in words)
            {
                if(item[0] < 'A' && item[0] > 'Z')
                {
                    words.Remove(item);
                }
            }
            StringBuilder result = new StringBuilder();
            Match firstPart = Regex.Match(input[0], firstPattern);
            MatchCollection secondPart = Regex.Matches(input[1], secondPattern);
            for (int i = 1; i < firstPart.Value.Length-1; i++)
            {
                foreach (Match character in secondPart)
                {
                    int[] second = character.Value
                        .Split(":", StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
                    if(second[0] == firstPart.Value[i])
                    {
                        foreach  (string word in words)
                        {
                            if(word[0] == second[0] && word.Length == second[1]+1)
                            {
                                result.AppendLine(word);
                                break;
                            }
                        }
                        break;
                    }
                }
            }
            Console.WriteLine(result.ToString().Trim());
        }
    }
}
