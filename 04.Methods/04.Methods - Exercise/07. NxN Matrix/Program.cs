using System;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            MatrixColumn(number);

        }

        static void MatrixColumn(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                MatrixRow(number);
            }
        }
        static void MatrixRow(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();


        }
    }
}
