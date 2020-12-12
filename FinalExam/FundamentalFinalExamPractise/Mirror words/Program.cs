using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Mirror_words
{
    class Program
    {
        public static object Matches { get; private set; }

        static void Main(string[] args)
        {
            string pattern = @"(\@|#)(?<first>[A-Za-z]{3,})\1\1(?<second>[A-Za-z]{3,})\1";
            string text = Console.ReadLine();
            MatchCollection match = Regex.Matches(text, pattern);
            List<Match> mirror = new List<Match>();
            if(match.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
                Console.WriteLine("No mirror words!");
                return;
            }
            else
            {
                Console.WriteLine($"{match.Count} word pairs found!");
                for (int i = 0; i < match.Count; i++)
                {
                    string first = match[i].Groups["first"].Value;
                    string second = match[i].Groups["second"].Value;
                    char[] secondChar = second.ToCharArray();
                    Array.Reverse(secondChar);
                    new String(secondChar);
                    if(new string(secondChar) == first)
                    {
                        mirror.Add(match[i]);
                    }            
                }
                if(mirror.Count != 0)
                {
                    Console.WriteLine("The mirror words are: ");
                    for (int i = 0; i < mirror.Count; i++)
                    {
                        if(i == mirror.Count - 1)
                        {
                            Console.Write($"{mirror[i].Groups["first"].Value} <=> { mirror[i].Groups["second"].Value}");
                            break;
                        }
                        Console.Write($"{mirror[i].Groups["first"].Value} <=> {mirror[i].Groups["second"].Value}, ");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("No mirror words!");
                }
            }
        }
    }
}
