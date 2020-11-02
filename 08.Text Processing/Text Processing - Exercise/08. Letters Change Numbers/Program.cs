using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Console.WriteLine($"{ReturnTotalSumOfListElements((ReturnChangeLetters(text))):f2}");
        }
        static List<string> ReturnChangeLetters(string[] text)
        {
            bool lowerOrUpperChar = true;
            List<string> letterInDigit = new List<string>();
            for (int i = 0; i < text.Length; i++)
            {
                string character = text[i];
                string digit = string.Empty;
                char action = '0';
                int positionOfAlphabet = 0;
                for (int k = 0; k < character.Length; k++)
                {
                    if (char.IsLetter(character[k]))
                    {
                        lowerOrUpperChar = Char.IsLower(character[k]);
                        if (char.IsLetter(character[k]) && positionOfAlphabet > 0)
                        {
                            if (action == '*')
                            {
                                digit = (decimal.Parse(digit) * positionOfAlphabet).ToString();
                            }
                            else
                            {
                                digit = (decimal.Parse(digit) / positionOfAlphabet).ToString();
                            }
                        }
                        if (lowerOrUpperChar)
                        {
                            positionOfAlphabet = character[k] - 96;
                            action = '*';
                        }
                        else
                        {
                            positionOfAlphabet = character[k] - 64;
                            action = '/';
                        }
                    }
                    else if (char.IsDigit(character[k]))
                    {
                        digit += character[k];
                    }
                }
                if (lowerOrUpperChar)
                {
                    digit = (decimal.Parse(digit) + positionOfAlphabet).ToString();
                }
                else
                {
                    digit = (decimal.Parse(digit) - positionOfAlphabet).ToString();
                }
                letterInDigit.Add(digit);
            }

            return letterInDigit;
        }
        static decimal ReturnTotalSumOfListElements(List<string> digit)
        {
            decimal totalSum = 0;
            foreach (var number in digit)
            {
                totalSum += decimal.Parse(number);
            }
            return totalSum;
        }
    }
}
