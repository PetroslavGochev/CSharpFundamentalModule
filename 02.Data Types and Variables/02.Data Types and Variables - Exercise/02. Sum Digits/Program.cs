using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int totalSum = 0;

            while (number > 0)
            {
                int sum = number;
                sum %= 10;
                number /= 10;
                totalSum += sum;
            }
            Console.WriteLine(totalSum);
        }
    }
}
