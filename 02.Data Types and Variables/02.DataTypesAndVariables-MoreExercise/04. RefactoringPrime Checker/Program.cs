using System;

namespace _04._RefactoringPrime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int until = int.Parse(Console.ReadLine());
            for (int i = 2; i <= until; i++)
            {
                bool isNumberIsPrime = true;
                for (int k = 2; k < i; k++)
                {
                    if (i % k == 0)
                    {
                        isNumberIsPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} ->
        }
    }
}
