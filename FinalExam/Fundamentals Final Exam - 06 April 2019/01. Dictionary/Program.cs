using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, int>> words = new SortedDictionary<string, Dictionary<string, int>>();
            for (int i = 1; i <= 3; i++)
            {
                string input = Console.ReadLine();
                var data = input
                         .Split(" | ", StringSplitOptions.RemoveEmptyEntries)
                         .ToArray();
                if (i == 1)
                {
                    for (int k = 0; k < data.Length; k++)
                    {
                        var text = data[k].Split(": ", StringSplitOptions.RemoveEmptyEntries);
                        AddWords(words, text);
                    }
                }
                else if (i == 2)
                {
                    PrintWords(words, data);
                }
                else if( input == "List")
                {
                    foreach (var word in words)
                    {
                        Console.Write($"{word.Key} ");
                    }
                }
            }
        }
        static void AddWords(SortedDictionary<string, Dictionary<string, int>> words, string[] text)
        {
                var definition = text[1];
                var word = text[0];
                if (!words.ContainsKey(text[0]))
                {
                    words.Add(word, new Dictionary<string, int>());
                }
            words[word].Add(definition, definition.Length);

        }
        static void PrintWords(SortedDictionary<string, Dictionary<string, int>> words, string[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (words.ContainsKey(data[i]))
                {
                    Console.WriteLine($"{data[i]}:");
                    foreach (var definition in words[data[i]].OrderByDescending(x=>x.Value))
                    {
                        Console.WriteLine($" -{definition.Key}");
                    }
                }
            }

        }
    }

}

