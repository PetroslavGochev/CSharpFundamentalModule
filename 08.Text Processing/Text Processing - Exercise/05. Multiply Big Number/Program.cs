using System;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine().TrimStart(new char[] { '0' });
            int multiplier = int.Parse(Console.ReadLine());
            string result = string.Empty;
            int multiply = 0;
            if (multiplier == 0)
            {
                Console.WriteLine("0");
                return;
            }
            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                multiply += int.Parse(firstNumber[i].ToString()) * multiplier;
                result += (multiply % 10).ToString();
                multiply /= 10;
            }
            if (multiply != 0)
            {
                result += multiply;
            }

            char[] array = result.ToCharArray();
            Array.Reverse(array);

            Console.WriteLine(string.Join("", array));
        }
    }
}
