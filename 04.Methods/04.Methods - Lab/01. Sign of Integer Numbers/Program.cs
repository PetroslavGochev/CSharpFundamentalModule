using System;

namespace _01._Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            SignOfIntegerNumber(int.Parse(Console.ReadLine()));


        }
        static void SignOfIntegerNumber(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }
}
