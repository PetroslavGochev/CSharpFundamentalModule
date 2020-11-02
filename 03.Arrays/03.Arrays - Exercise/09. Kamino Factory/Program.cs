using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string text;
            int arrayNum = 0;
            int maxSum = 0;
            int minIndex = 0;
            int maxSeries = 0;
            int[] big = new int[number];
            int numberOfArray = 0;
            while ((text = Console.ReadLine()) != "Clone them!")
            {
                int[] array = text.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int series = 0;
                int count = 1;
                int index = 0;
                int totalSum = 0;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] == array[i + 1])
                    {
                        count++;
                        if (count > series)
                        {
                            series = count;
                            index = i;
                        }
                    }
                    else
                    {
                        count = 0;
                    }
                    totalSum += array[i];
                }
                totalSum += array[number - 1];
                numberOfArray++;
                if (series > maxSeries)
                {
                    maxSeries = series;
                    minIndex = index;
                    maxSum = totalSum;
                    big = array.ToArray();
                    arrayNum = numberOfArray;
                }
                else if (series == maxSeries)
                {
                    if (minIndex > index)
                    {
                        minIndex = index;
                        maxSum = totalSum;
                        big = array.ToArray();
                        arrayNum = numberOfArray;
                    }
                    else if (minIndex == index)
                    {
                        if (maxSum < totalSum)
                        {
                            big = array.ToArray();
                            arrayNum = numberOfArray;
                            maxSum = totalSum;
                        }
                    }
                }
            }
            Console.WriteLine($"Best DNA sample {arrayNum} with sum: {maxSum}.");
            Console.WriteLine(String.Join(' ', big));
        }
    }
}
