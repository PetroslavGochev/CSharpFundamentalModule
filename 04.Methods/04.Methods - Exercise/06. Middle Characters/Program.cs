using System;
using System.Text;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            if (text.Length % 2 == 0)
            {
                Console.WriteLine(ReturnMiddleCharactersEven(text));
            }
            else
            {
                Console.WriteLine(ReturnMiddleCharactersOdd(text));
            }

        }

        static char ReturnMiddleCharactersOdd(string text)
        {
            char result = text[text.Length / 2];
            return result;


        }

        static string ReturnMiddleCharactersEven(string text)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i <= 1; i++)
            {
                result.Append(text[(text.Length / 2) - 1 + i]);
            }
            return result.ToString();
        }

    }
}
