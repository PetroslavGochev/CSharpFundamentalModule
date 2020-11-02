using System;
using System.Linq;

namespace _05._Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
            int totalSum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] % 2 == 0)
                {
                    totalSum += number[i];
                }
            }
            Console.WriteLine(totalSum);
        }
    }
}
