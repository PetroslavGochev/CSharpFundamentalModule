using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
             .Split()
             .Select(int.Parse)
             .ToArray();
            int symbol = 0;
            int max = 0;
            int number = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    symbol++;
                    if (symbol > max)
                    {
                        max = symbol;
                        number = arr[i];
                    }
                }
                else
                {
                    symbol = 0;

                }
            }
            string[] newArr = new string[max + 1];
            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = number.ToString();
            }
            Console.WriteLine(String.Join(" ", newArr));
        }
    }
}
