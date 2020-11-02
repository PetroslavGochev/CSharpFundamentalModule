using System;

namespace _03._Exact_Sum_of_Real
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            decimal sum = 0;

            for (int i = 1; i <= number; i++)
            {
                double n = double.Parse(Console.ReadLine());
                sum += (decimal)n;
            }
            Console.WriteLine(sum);
        }
    }
}
