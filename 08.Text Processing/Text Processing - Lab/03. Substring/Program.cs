using System;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLowerInvariant();
            string text = Console.ReadLine();
            while (text.IndexOf(word) >= 0)
            {
                text = text.Remove(text.IndexOf(word), word.Length);
            }
            Console.WriteLine(text);
        }
    }
}
