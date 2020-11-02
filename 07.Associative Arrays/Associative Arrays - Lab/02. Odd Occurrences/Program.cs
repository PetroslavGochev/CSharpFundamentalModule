using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayWithElements = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.ToLowerInvariant())
                .ToArray();
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (string word in arrayWithElements)
            {
                if (dict.ContainsKey(word))
                {
                    dict[word]++;
                }
                else
                {
                    dict.Add(word, 1);
                }
            }
            foreach (var key in dict)
            {
                if (key.Value % 2 != 0)
                {
                    Console.Write($"{key.Key} ");
                }

            }
        }
    }
}
