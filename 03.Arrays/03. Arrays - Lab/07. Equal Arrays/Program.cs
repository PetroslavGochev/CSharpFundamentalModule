using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num1 = Console.ReadLine()
           .Split()
           .Select(int.Parse)
           .ToArray();
            int[] num2 = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();
            int totalSum = 0;
            int i;
            for (i = 0; i < num1.Length; i++)
            {
                if (num1[i] == num2[i])
                {
                    totalSum += num1[i];
                }
                else
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }

            }
            if (i == num1.Length)
            {
                Console.WriteLine($"Arrays are identical. Sum: {totalSum}");
            }

        }
    }
}
