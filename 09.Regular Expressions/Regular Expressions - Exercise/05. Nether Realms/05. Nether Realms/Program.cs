using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _05._Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfDemon = Console.ReadLine()
                .Split(",", StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToList();
            SortedDictionary<string, List<double>> checkDemon = new SortedDictionary<string, List<double>>();
            string patternLetter = @"[\d\s,.\-\*\/]";
            string patternDigit = @"[-|+]?[0.0-9]+";
            string patternAction = @"[^\/*]";
            for (int i = 0; i < listOfDemon.Count; i++)
            {
                if(listOfDemon[i].Contains(" "))
                {
                    continue;
                }
                string demonLetter = Regex.Replace(listOfDemon[i], patternLetter, "");
                if(demonLetter.Length == 0)
                {
                    continue;
                }
                MatchCollection match = Regex.Matches(listOfDemon[i], patternDigit);
                string action = Regex.Replace(listOfDemon[i], patternAction, "");
                double health = 0;
                double damage = 0;
                foreach (var digit in match)
                {
                    damage += double.Parse(digit.ToString());
                }
                foreach(var character in action)
                {
                    if(character == '*')
                    {
                        damage *= 2.00;
                    }
                    else if(character == '/')
                    {
                        damage /= 2.00;
                    }
                }
                foreach (var character in demonLetter)
                {
                    health += (char)character;
                }
                checkDemon.Add(listOfDemon[i], new List<double>());
                checkDemon[listOfDemon[i]].Add(health);
                checkDemon[listOfDemon[i]].Add(damage);
            }
            if(checkDemon.Count > 0)
            {
                Console.WriteLine(PrintResult(checkDemon));
            }
        }
           
        static string PrintResult (SortedDictionary<string,List<double>>checkDemon)
        {
            StringBuilder result = new StringBuilder();
            foreach (var demon in checkDemon)
            {
                    result.AppendLine($"{demon.Key} - {demon.Value[0]} health, {demon.Value[1]:f2} damage");
            }
            return result.ToString().Trim();
        }
        }
    }

