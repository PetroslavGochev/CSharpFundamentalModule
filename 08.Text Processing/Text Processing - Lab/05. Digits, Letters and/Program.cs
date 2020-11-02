using System;
using System.Text;

namespace _05._Digits__Letters_and
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder digit = new StringBuilder();
            StringBuilder letter = new StringBuilder();
            StringBuilder symbol = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    digit.Append(text[i]);
                }
                else if (char.IsLetter(text[i]))
                {
                    letter.Append(text[i]);
                }
                else
                {
                    symbol.Append(text[i]);
                }
            }
            Console.WriteLine(digit);
            Console.WriteLine(letter);
            Console.WriteLine(symbol);
        }
    }
}
