using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(SubtractFirstAndSecondWithThird(SumFirstAndSecond(firstNumber, secondNumber), thirdNumber));

        }

        static int SumFirstAndSecond(int first, int second)
        {
            int result = first + second;
            return result;
        }
        static int SubtractFirstAndSecondWithThird(int first, int second)
        {
            int result = first - second;
            return result;
        }
    }
}
