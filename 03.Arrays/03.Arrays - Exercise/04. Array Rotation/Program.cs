using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
             .Split()
             .Select(int.Parse)
             .ToArray();
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                int temp = 0;
                for (int k = 0; k < arr.Length - 1; k++)
                {
                    temp = arr[k];
                    arr[k] = arr[k + 1];
                    arr[k + 1] = temp;
                }
            }
            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
