using System;
using System.Text;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string number;
            while ((number = Console.ReadLine()) != "END")
            {
                if (CheckPolindromeIntegers(int.Parse(number)))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }

            }

        }

        static bool CheckPolindromeIntegers(int number)
        {
            StringBuilder newNumber = new StringBuilder();
            int oldNumber = number;

            bool flag = false;
            while (number > 0)
            {
                int digit = number % 10;
                newNumber.Append(digit);
                number = number / 10;
            }
            if (int.Parse(newNumber.ToString()) == oldNumber)
            {
                flag = true;
            }
            return flag;
        }
    }
}
