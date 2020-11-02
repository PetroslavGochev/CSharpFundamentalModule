using System;
using System.Linq;

namespace _04._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] readIntegerFromConsolee = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();
            int[] firstArray = new int[readIntegerFromConsolee.Length / 4];
            int[] secondArray = new int[readIntegerFromConsolee.Length / 4];
            int[] thirdArray = new int[readIntegerFromConsolee.Length / 2];
            int k = 0;
            for (int i = firstArray.Length - 1; i >= 0; i--)
            {
                firstArray[i] = readIntegerFromConsolee[i];
            }
            for (int i = readIntegerFromConsolee.Length - readIntegerFromConsolee.Length / 4; i < readIntegerFromConsolee.Length; i++)
            {

                secondArray[k] = readIntegerFromConsolee[i];
                k++;
            }
            k = 0;
            for (int i = readIntegerFromConsolee.Length / 4; i < readIntegerFromConsolee.Length / 4 + thirdArray.Length; i++)
            {
                thirdArray[k] = readIntegerFromConsolee[i];
                k++;
            }
            Array.Reverse(firstArray);
            Array.Reverse(secondArray);
            int[] arrayOfResult = new int[readIntegerFromConsolee.Length / 2];
            k = 0;
            for (int i = 0; i < arrayOfResult.Length; i++)
            {
                if (i < readIntegerFromConsolee.Length / 4)
                {
                    arrayOfResult[i] = firstArray[i] + thirdArray[i];
                }
                else
                {
                    arrayOfResult[i] = secondArray[k] + thirdArray[i];
                    k++;
                }

            }
            Console.WriteLine(string.Join(" ", arrayOfResult));

        }
    }
    }

