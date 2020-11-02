using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .Split()
                .ToList();
            Dictionary<char, int> dictOfChar = new Dictionary<char, int>();
            foreach (string word in words)
            {
                foreach (char symbol in word)
                {
                    if (dictOfChar.ContainsKey(symbol))
                    {
                        dictOfChar[symbol]++;
                    }
                    else
                    {
                        dictOfChar.Add(symbol, 1);
                    }
                }
            }

            foreach (var index in dictOfChar)
            {
                Console.WriteLine($"{index.Key} -> {index.Value}");
            }
        }
    }
}
