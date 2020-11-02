using System;
using System.Collections.Generic;

namespace _03._Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfWords = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            for (int i = 1; i <= countOfWords; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!dict.ContainsKey(word))
                {
                    dict.Add(word, new List<string>());
                    dict[word].Add(synonym);
                }
                else
                {
                    dict[word].Add(synonym);
                }
            }
            foreach (var word in dict)
            {
                Console.WriteLine($"{word.Key} - {String.Join(", ", word.Value)}");
            }
        }
    }
}
