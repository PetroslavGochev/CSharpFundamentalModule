using System;

namespace Unique_PIN_CODES
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int totalSum = 0;
            for (int i = 1; i <= number * 2; i += 2)
            {
                Console.WriteLine(i);
                totalSum += i;
            }
            Console.WriteLine($"Sum: {totalSum}");
        }
    }
}
