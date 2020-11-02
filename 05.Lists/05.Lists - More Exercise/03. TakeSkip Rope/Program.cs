using System;
using System.Collections.Generic;
using System.Text;

namespace _03._TakeSkip_Rope
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            TakeDigitAndLetter(text);
        }

        static void TakeDigitAndLetter(string text)
        {
            List<int> listOfDigit = new List<int>();
            List<char> listOfNonNumber = new List<char>();
            List<int> skipList = new List<int>();
            List<int> takeList = new List<int>();
            foreach (var symbol in text)
            {
                if (Char.IsDigit(symbol))
                {
                    listOfDigit.Add(int.Parse(symbol.ToString()));
                }
                else
                {
                    listOfNonNumber.Add(symbol);
                }
            }
            ReturnOddOrEveneList(skipList, takeList, listOfDigit, listOfNonNumber);
        }
        static void ReturnOddOrEveneList(List<int> skipList, List<int> takeList, List<int> listOfDigit, List<char> listOfNonNumbers)
        {
            for (int i = 0; i < listOfDigit.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(listOfDigit[i]);
                }
                else
                {
                    skipList.Add(listOfDigit[i]);
                }
            }
            Console.WriteLine($"{ReturnResult(listOfNonNumbers, skipList, takeList)}");
        }
        static string ReturnResult(List<char> listOfNonNumber, List<int> skipList, List<int> takelist)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < takelist.Count; i++)
            {
                int take = takelist[i];
                int skip = skipList[i];
                result.Append(TakeElement(listOfNonNumber, take));
                SkipElement(listOfNonNumber, skip);
            }
            return result.ToString();
        }
        static string TakeElement(List<char> listOfNonNumber, int take)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < take; i++)
            {
                result.Append(listOfNonNumber[i]);
                if (i == listOfNonNumber.Count - 1)
                {
                    return result.ToString();
                }
            }
            listOfNonNumber.RemoveRange(0, take);
            return result.ToString();
        }
        static void SkipElement(List<char> listOfNonNumber, int skip)
        {
            if (skip == 0)
            {
                return;
            }
            listOfNonNumber.RemoveRange(0, skip);
        }
    }
}
