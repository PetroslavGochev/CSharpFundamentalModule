using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            ReturnTopNumber(number);

        }

        static void ReturnTopNumber(int number)
        {
            int divisible = 8;
            for (int i = 1; i <= number; i++)
            {
                if (CheckSumOfDigits(i) % divisible == 0 && CheckOddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static int CheckSumOfDigits(int number)
        {
            string digit = number.ToString();
            int sum = 0;
            for (int i = 0; i < digit.Length; i++)
            {
                sum += int.Parse(digit[i].ToString());
            }
            return sum;
        }

        static bool CheckOddDigit(int number)
        {
            bool flag = false;
            string digitOdd = number.ToString();
            for (int i = 0; i < digitOdd.Length; i++)
            {
                if (int.Parse(digitOdd[i].ToString()) % 2 != 0)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
    }
}
