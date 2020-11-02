using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine($"{DivideSum(FactorialOfFirstNumber(firstNumber), FactorialOfSecondNumber(secondNumber)):f2}");

        }
        static double FactorialOfFirstNumber(double firstNumber)
        {
            double firstFactorial = firstNumber;


            for (double i = firstNumber - 1; i >= 1; i--)
            {
                firstFactorial = firstFactorial * i;
            }


            return firstFactorial;
        }
        static double FactorialOfSecondNumber(double secondNumber)
        {
            double secondFactorial = secondNumber;
            for (double i = secondNumber - 1; i >= 1; i--)
            {
                secondFactorial = secondFactorial * i;
            }
            return secondFactorial;
        }
        static double DivideSum(double first, double second)
        {
            double result = first / second;
            return result;
        }
    }
}
