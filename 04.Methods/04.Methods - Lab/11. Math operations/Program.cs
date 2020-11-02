using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine(CalculationOfNumbers(firstNumber, secondNumber, operation));
        }
        static double CalculationOfNumbers(double firstNumber, double secondNumber, char operation)
        {
            double result = 0;
            if (operation == '+')
            {
                result = firstNumber + secondNumber;
            }
            else if (operation == '-')
            {
                result = firstNumber - secondNumber;
            }
            else if (operation == '*')
            {
                result = firstNumber * secondNumber;
            }
            else
            {
                result = firstNumber / secondNumber;
            }
            return result;
        }
    }
}
