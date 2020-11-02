using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                int digitSum = 0;
                int digits = i;
                while (digits > 0)
                {
                    digitSum += digits % 10;
                    digits /= 10;
                }
                if (digitSum == 7 || digitSum == 5 || digitSum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }


            }
        }
    }
}
