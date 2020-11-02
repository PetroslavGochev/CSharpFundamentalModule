using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string[] arrOne = new string[number];
            string[] arrTwo = new string[number];

            for (int i = 0; i < number; i++)
            {
                string[] text = Console.ReadLine().Split().ToArray();
                if (i % 2 == 0)
                {
                    arrOne[i] = text[0];
                    arrTwo[i] = text[1];
                }
                else
                {
                    arrOne[i] = text[1];
                    arrTwo[i] = text[0];
                }

            }
            Console.WriteLine(String.Join(" ", arrOne));
            Console.WriteLine(String.Join(" ", arrTwo));
        }
    }
}
