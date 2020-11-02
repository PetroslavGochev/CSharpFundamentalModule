using System;
using System.Linq;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int[] numbers = new int[3] { first, second, third };
            Console.WriteLine(GetMinNumber(numbers));
        }
        static int GetMinNumber(int[] array)
        {
            return array.Min();
        }
    }
}
