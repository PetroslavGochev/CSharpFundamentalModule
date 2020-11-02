using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                int k;
                for (k = i + 1; k < arr.Length; k++)
                {
                    if (arr[i] > arr[k])
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }

                }
                if (k == arr.Length)
                {
                    Console.Write($"{arr[i]} ");
                }
            }
        }
    }
}
