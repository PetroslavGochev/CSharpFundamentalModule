using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] text = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int leftSum = 0;
            int rightSum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                leftSum = 0;
                rightSum = 0;

                for (int k = 0; k < text.Length; k++)
                {
                    if (k < i)
                    {
                        leftSum += text[k];
                    }
                    else if (k > i)
                    {
                        rightSum += text[k];
                    }
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
            if (leftSum != rightSum)
            {
                Console.WriteLine("no");
            }
        }
    }
}
