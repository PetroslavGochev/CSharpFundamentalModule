using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();
            input = input.OrderByDescending(x => x).ToList();
            if (input.Count < 3)
            {
                foreach (int numebr in input)
                {
                    Console.Write($"{numebr} ");
                }
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"{input[i]} ");
                }

            }
        }
    }
}
