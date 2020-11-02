using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            int length = firstList.Count;
            for (int i = 0; i < length / 2; i++)
            {
                firstList[i] += firstList[firstList.Count - 1];
                firstList.RemoveAt(firstList.Count - 1);
            }
            Console.WriteLine(string.Join(" ", firstList));
        }
    }
}
