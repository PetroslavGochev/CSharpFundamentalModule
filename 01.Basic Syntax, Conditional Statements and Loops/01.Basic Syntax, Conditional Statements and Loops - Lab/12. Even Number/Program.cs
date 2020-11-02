using System;

namespace Unique_PIN_CODES
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int number = int.Parse(Console.ReadLine());
                if (number % 2 != 0)
                {
                    Console.WriteLine($"Please write an even number.");
                }
                else
                {
                    Console.WriteLine($"The number is: {Math.Abs(number)}");
                    break;
                }
            }
        }
    }
}
