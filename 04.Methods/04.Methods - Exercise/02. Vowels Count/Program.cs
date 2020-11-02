using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine(GetVowels(text));
        }
        static int GetVowels(string text)
        {
            int counter = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'A' || text[i] == 'a' || text[i] == 'e' || text[i] == 'E' || text[i] == 'I' || text[i] == 'i' || text[i] == 'o' || text[i] == 'O'
                    || text[i] == 'u' || text[i] == 'U' || text[i] == 'y' || text[i] == 'Y')
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
