using System;

namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split();
            double[] numbers = new double[text.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = double.Parse(text[i]);
                if (numbers[i] == 0)
                {
                    numbers[i] = 0;
                }
                Console.WriteLine($"{numbers[i]} => {(int)Math.Round(numbers[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
