using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string action = Console.ReadLine();
            double numOne = double.Parse(Console.ReadLine());
            double numTwo = double.Parse(Console.ReadLine());

            if (action == "add")
            {
                Add(numOne, numTwo);
            }
            else if (action == "divide")
            {
                Divide(numOne, numTwo);
            }
            else if (action == "multiply")
            {
                Multiply(numOne, numTwo);
            }
            else
            {
                Subtract(numOne, numTwo);
            }
        }
        static void Add(double numOne, double numTwo)
        {
            double result = numOne + numTwo;
            Console.WriteLine(result);
        }
        static void Multiply(double first, double second)
        {
            double result = first * second;
            Console.WriteLine(result);
        }
        static void Divide(double first, double second)
        {
            double result = first / second;
            Console.WriteLine(result);
        }
        static void Subtract(double first, double second)
        {
            double result = first - second;
            Console.WriteLine(result);
        }
    }
}
