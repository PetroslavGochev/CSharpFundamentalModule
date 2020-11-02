using System;
using System.Linq;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrOne = Console.ReadLine().Split().ToArray();
            string[] arrTwo = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < arrOne.Length; i++)
            {
                for (int k = 0; k < arrTwo.Length; k++)
                {
                    if (arrOne[i] == arrTwo[k])
                    {
                        Console.Write($"{arrOne[i]} ");
                    }
                }
            }
        }
    }
}
