using System;

namespace _03._Floating_Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            double eps = 0.000001;
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double result = firstNumber - secondNumber;
            if (Math.Abs(result) >= eps)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
        }
    }
}
