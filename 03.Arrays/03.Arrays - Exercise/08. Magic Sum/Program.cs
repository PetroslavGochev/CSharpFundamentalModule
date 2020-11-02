using System;
using System.Linq;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
             .Split()
             .Select(int.Parse)
             .ToArray();
            int magicNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                for (int k = i; k < arr.Length - 1; k++)
                {
                    if (arr[i] + arr[k + 1] == magicNumber)
                    {
                        Console.WriteLine(String.Join(" ", arr[i], arr[k + 1]));
                    }
                }

            }
        }
    }
}
