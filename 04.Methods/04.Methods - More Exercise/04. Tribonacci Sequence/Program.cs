using System;

namespace _04._Tribonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number == 0)
            {
                Console.WriteLine("0");
            }
            else if (number == 1)
            {
                Console.WriteLine("1");
            }
            else if (number == 2)
            {

                Console.WriteLine("1 1");
            }
            else if (number == 3)
            {
                Console.WriteLine("1 1 2");
            }
            else
            {
                PrintTribonacciSequence(number);
            }
        }
        static void PrintTribonacciSequence(int numebr)
        {
            Console.Write("1 1 2");
            int first = 1;
            int second = 1;
            int third = 2;
            int num = 0;
            for (int i = 0; i < numebr - 3; i++)
            {
                num = first + second + third;
                first = second;
                second = third;
                third = num;
                Console.Write($" {num}");
            }
        }
    }
}
