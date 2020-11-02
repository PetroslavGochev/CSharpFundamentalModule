using System;
using System.Linq;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split()
                .ToArray();
            string firstText = text[0];
            string secondText = text[1];
            Console.WriteLine(ReturnTotalSumOfTwoStrings(firstText, secondText));
        }

        static int ReturnTotalSumOfTwoStrings(string first, string second)
        {
            int totalSum = 0;
            int maxTextLenght = 0;
            if (first.Length >= second.Length)
            {
                maxTextLenght = first.Length;

            }
            else
            {
                maxTextLenght = second.Length;
            }
            for (int i = 0; i < maxTextLenght; i++)
            {
                if (i >= second.Length)
                {
                    totalSum += first[i];
                }
                else if (i >= first.Length)
                {
                    totalSum += second[i];
                }
                else
                {
                    totalSum += first[i] * second[i];
                }
            }
            return totalSum;

        }
    }
}
