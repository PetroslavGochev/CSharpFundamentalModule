using System;
using System.Globalization;
using System.Linq;
using System.Numerics;

namespace _06._Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
            int totalSumEven = 0;
            int totalSumOdd = 0;

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] % 2 == 0)
                {
                    totalSumEven += number[i];
                }
                else
                {
                    totalSumOdd += number[i];
                }
            }
            Console.WriteLine(totalSumEven - totalSumOdd);
        }
    }
}
