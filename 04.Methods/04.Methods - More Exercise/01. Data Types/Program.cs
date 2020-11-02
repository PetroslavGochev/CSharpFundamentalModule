using System;

namespace _01._Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string secondText = Console.ReadLine();
            if (text == "int")
            {
                MultiplyBy2(int.Parse(secondText));
            }
            else if (text == "real")
            {
                MiltplyByReal(double.Parse(secondText));
            }
            else
            {
                PrintString(secondText);
            }
        }
        static void MultiplyBy2(int number)
        {
            Console.WriteLine(number * 2);
        }
        static void MiltplyByReal(double number)
        {
            Console.WriteLine($"{number * 1.5:F2}");
        }
        static void PrintString(string text)
        {
            Console.WriteLine($"${text}$");
        }
    }
}
