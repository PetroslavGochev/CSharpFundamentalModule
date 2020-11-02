using System;

namespace _01._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int maximum = Math.Max(Math.Max(first, second), third);
            int minimum = Math.Min(Math.Min(first, second), third);
            int average = (first + second + third) - (maximum + minimum);
            Console.WriteLine(maximum);
            Console.WriteLine(average);
            Console.WriteLine(minimum);
        }
    }
}
