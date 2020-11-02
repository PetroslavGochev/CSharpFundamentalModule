using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> firstList = Console.ReadLine().Split().Select(double.Parse).ToList();

            for (int i = 0; i < firstList.Count; i++)
            {
                if (i == firstList.Count - 1)
                {
                    break;
                }
                if (firstList[i] == firstList[i + 1])
                {
                    firstList[i] += firstList[i + 1];
                    firstList.RemoveAt(i + 1);
                    i = -1;

                }
            }
            Console.WriteLine(string.Join(" ", firstList));
        }
    }
}
