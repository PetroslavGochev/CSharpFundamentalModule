using System;

namespace _12._Refactor_Special
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int digit = 0;
            bool flag = false;
            for (int num = 1; num <= number; num++)
            {
                digit = num;
                while (num > 0)
                {
                    sum += num % 10;
                    num = num / 10;
                }
                flag = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", digit, flag);
                sum = 0;
                num = digit;
            }
    }
}
