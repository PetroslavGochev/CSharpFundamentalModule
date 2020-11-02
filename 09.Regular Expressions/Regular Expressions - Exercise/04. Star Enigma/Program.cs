using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string star = "[sStTaArR]";
            string pattern = @"[\w]*@(?<planet>[A-Za-z]+)[^@\-!:>]*:(?<population>[\d]+)\!(?<attack>[AD])![^@\-!:>]*->(?<soldier>[\d]+)";
            List<string> attack = new List<string>();
            List<string> destroy = new List<string>();
            for (int i = 1; i <= number; i++)
            {
                string message = Console.ReadLine();
                MatchCollection match = Regex.Matches(message, star);
                int counter = match.Count;
                string decryptMessage = string.Empty;
                foreach (var item in message)
                {
                    decryptMessage += (char)(item - counter);
                }
                Match planet = Regex.Match(decryptMessage, pattern);
                if (planet.Groups["attack"].Value == "A")
                {
                    attack.Add(planet.Groups["planet"].Value);
                }
                else if(planet.Groups["attack"].Value == "D")
                {
                    destroy.Add(planet.Groups["planet"].Value);
                }
            }
            Console.WriteLine(PrintResult(attack, destroy));
        }
        static string PrintResult (List<string> attack, List<string> destroy)
        {
            attack = attack.OrderBy(x=>x).ToList();
            destroy =  destroy.OrderBy(x=>x).ToList();
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Attacked planets: {attack.Count}");
            foreach (var planet in attack)
            {
                result.AppendLine($"-> {planet}");
            }
            result.AppendLine($"Destroyed planets: {destroy.Count}");
            foreach (var planet in destroy)
            {
                result.AppendLine($"-> {planet}");
            }
            return result.ToString().Trim();
        }
    }
}
