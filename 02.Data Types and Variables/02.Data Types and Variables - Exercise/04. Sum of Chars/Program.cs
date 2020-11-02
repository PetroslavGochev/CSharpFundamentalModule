using System;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalSum = 0;

            for (int i = 1; i <= n; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                totalSum += symbol;

            }
            Console.WriteLine($"The sum equals: { totalSum}");
        }
    }
}
