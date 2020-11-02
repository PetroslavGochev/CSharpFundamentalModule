using System;

namespace _02._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] firstArray = new int[] { };
            for (int i = 1; i <= number; i++)
            {
                int[] secondArray = new int[i];

                for (int k = 0; k < i; k++)
                {
                    if (k == 0)
                    {
                        secondArray[0] = 1;
                    }
                    else if (firstArray.Length == k)
                    {

                        secondArray[k] = firstArray[firstArray.Length - 1];
                    }
                    else
                    {
                        secondArray[k] = firstArray[k - 1] + firstArray[k];
                    }
                }
                firstArray = secondArray;
                Console.WriteLine(string.Join(" ", firstArray));
            }
        }
    }
}
