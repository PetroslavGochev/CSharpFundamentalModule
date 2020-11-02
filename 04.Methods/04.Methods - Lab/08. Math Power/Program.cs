using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double pow = double.Parse(Console.ReadLine());
            Console.WriteLine(MathPow(number, pow));
        }

        static double MathPow(double number, double pow)
        {
            double result = 0.0;
            result = Math.Pow(number, pow);
            return result;
        }
    }
}
