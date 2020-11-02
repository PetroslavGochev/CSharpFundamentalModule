using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] allNum = new int[number];

            for (int i = 0; i < number; i++)
            {
                int num = int.Parse(Console.ReadLine());
                allNum[i] = num;

            }
            for (int k = number; k > 0; k--)
            {
                Console.Write($"{allNum[k - 1]} ");
            }
        }
    }
}
