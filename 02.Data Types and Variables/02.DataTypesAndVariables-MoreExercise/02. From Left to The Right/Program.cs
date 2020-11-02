using System;
using System.Linq;
using System.Numerics;

namespace _02._From_Left_to_The_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                BigInteger[] line = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(BigInteger.Parse)
                    .ToArray();
                BigInteger bigerNumber = 0;
                if (line[0] > line[1])
                {
                    bigerNumber = line[0];
                }
                else
                {
                    bigerNumber = line[1];
                }
                BigInteger totalSum = 0;
                while (true)
                {
                    totalSum += bigerNumber % 10;
                    bigerNumber /= 10;
                    if (bigerNumber == 0)
                    {
                        break;
                    }
                }
                Console.WriteLine($"{Math.Abs((int)totalSum)}");
            }
        }
    }
}
