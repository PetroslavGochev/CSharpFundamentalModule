using System;
using System.Numerics;

namespace _02._Big_Factorial
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial.FactorialOfNumber(num));


        }
    }
    public class Factorial
    {
        public static BigInteger FactorialOfNumber(int number)
        {
            BigInteger totalSum = 1;
            for (int i = 1; i <= number; i++)
            {
                totalSum *= i;
            }
            return totalSum;
        }
    }
}
