using System;

namespace _03._Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] fibonaci = new int[50];
            fibonaci[0] = 0;
            fibonaci[1] = 1;
            for (int i = 2; i < fibonaci.Length; i++)
            {
                fibonaci[i] = fibonaci[i - 2] + fibonaci[i - 1];
            }
            Console.WriteLine(fibonaci[number]);
        }
    }
}
