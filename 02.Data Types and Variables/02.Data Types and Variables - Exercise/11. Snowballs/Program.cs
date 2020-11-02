using System;
using System.Numerics;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger maxValue = 0;
            int quantity = 0;
            int time = 0;
            int snow = 0;

            for (int i = 1; i <= n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuantity = int.Parse(Console.ReadLine());
                BigInteger totalSum = BigInteger.Pow((snowballSnow / snowballTime), snowballQuantity);

                if (totalSum > maxValue)
                {
                    maxValue = totalSum;
                    snow = snowballSnow;
                    time = snowballTime;
                    quantity = snowballQuantity;

                }

            }
            Console.WriteLine($"{snow} : {time} = {maxValue} ({quantity})");
        }
    }
}
