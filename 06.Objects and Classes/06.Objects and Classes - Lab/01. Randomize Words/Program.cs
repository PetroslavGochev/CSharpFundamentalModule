using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine().Split().ToList();
            Random rnd = new Random();
            for (int i = 0; i < text.Count; i++)
            {
                int randomIndex = rnd.Next(0, text.Count);
                string firstText = text[randomIndex];
                string secondText = text[i];


                text[randomIndex] = secondText;
                text[i] = firstText;
            }
            foreach (string randomText in text)
            {
                Console.WriteLine(randomText);
            }
        }
    }
}
