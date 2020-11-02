using System;

namespace Unique_PIN_CODES
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            for (int i = numberTwo; i <= 10; i++)
            {
                Console.WriteLine($"{numberOne} X {i} = {numberOne * i}");
            }
            if (numberTwo > 10)
            {
                Console.WriteLine($"{numberOne} X {numberTwo} = {numberOne * numberTwo}");
            }
        }
    }
}
