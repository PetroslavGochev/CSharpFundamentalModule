using System;

namespace _05._Multiplication_Sign
{
    class Program
    {
        static void Main(string[] args)
        {

            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int[] arrayOfNumber = new int[]
            {
                number1,
                number2,
                number3
            };
            Console.WriteLine($"{PrintProduct(arrayOfNumber)}");

        }
        static string PrintProduct(int[] arrayOfNumber)
        {
            int counter = 0;
            foreach (var number in arrayOfNumber)
            {
                if (number == 0)
                {

                    return "zero";
                }
                if (number < 0)
                {
                    counter++;
                }
            }
            if (counter % 2 == 0)
            {
                return "positive";
            }
            else
            {
                return "negative";
            }
        }
    }
}
