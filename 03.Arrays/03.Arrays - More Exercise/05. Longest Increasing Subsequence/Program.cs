using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfDigit = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int[] bestList;
            List<int> len = new List<int>();
            List<int> prev = new List<int>();
            int maximum = 0;
            int lastIndex = -1;
            for (int i = 0; i < listOfDigit.Count; i++)
            {
                len.Add(1);
                prev.Add(-1);
                for (int j = 0; j < i; j++)
                {
                    if (listOfDigit[j] < listOfDigit[i] && len[j] >= len[i])
                    {
                        len[i] = 1 + len[j];
                        prev[i] = j;
                    }
                }
                if (len[i] > maximum)
                {
                    maximum = len[i];
                    lastIndex = i;
                }
            }
            bestList = new int[maximum];
            for (int i = 0; i < bestList.Length; i++)
            {
                bestList[i] = listOfDigit[lastIndex];
                lastIndex = prev[lastIndex];
            }
            Array.Reverse(bestList);

            Console.WriteLine(string.Join(" ", bestList));
        }
    }
}
