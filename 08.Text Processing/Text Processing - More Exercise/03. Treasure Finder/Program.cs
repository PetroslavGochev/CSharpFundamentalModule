using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._Treasure_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] counter = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string text = string.Empty;
            string pattern = @"&[\w]+&|<[\w]+>";
            while ((text = Console.ReadLine())!= "find")
            {
                int count = 0;
                string decryptMessage = string.Empty;
                for (int i = 0; i < counter.Length; i++)
                {
                    decryptMessage += (char)(text[count] - counter[i]);
                    count++;
                    if(count == text.Length)
                    {
                        break;
                    }
                    if (i == counter.Length - 1)
                    {
                        i = -1;
                    }
                }
                MatchCollection match = Regex.Matches(decryptMessage, pattern);
                List<string> listOfMessage = match.Select(x => x.Value).ToList();
                string str = $"{listOfMessage[0].Replace("&", " ")}at{listOfMessage[1].Replace("<"," ").Replace(">","")}";
                
                Console.WriteLine($"Found{str}");
            }
            
        }
    }
}
