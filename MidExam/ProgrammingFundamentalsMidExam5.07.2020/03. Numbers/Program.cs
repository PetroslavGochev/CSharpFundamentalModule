using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfInteger = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            double average = listOfInteger.Average();
            var result = listOfInteger
                .OrderByDescending(x => x)
                .Where(x => x > average)
                .Take(5)
                .ToList();
            if (result.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine(string.Join(" ", result));
            }
        }
    }
}
