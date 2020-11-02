using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> listOfIntegers = (Console.ReadLine())
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();
            SortedDictionary<double, double> dict = new SortedDictionary<double, double>();
            foreach (double number in listOfIntegers)
            {
                if (dict.ContainsKey(number))
                {
                    dict[number]++;
                }
                else
                {
                    dict.Add(number, 1);
                }
            }

            foreach (var key in dict)
            {
                Console.WriteLine($"{key.Key} -> {key.Value}");
            }
        }
    }
}

