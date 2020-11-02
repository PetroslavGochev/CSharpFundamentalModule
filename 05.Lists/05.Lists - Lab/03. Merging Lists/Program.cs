using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();
            Console.WriteLine(String.Join(" ", ReturnMergingList(firstList, secondList)));
        }
        static List<int> ReturnMergingList(List<int> first, List<int> second)
        {
            List<int> result = new List<int>();
            int max = Math.Max(first.Count, second.Count);
            for (int i = 0; i < max; i++)
            {
                if (first.Count > i)
                {
                    result.Add(first[i]);
                }
                if (second.Count > i)
                {
                    result.Add(second[i]);
                }

            }

            return result;
        }
    }
}
