using System;
using System.Linq;

namespace _01._Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] arrSort = new int[number];

            for (int index = 0; index < number; index++)
            {
                char[] arr = Console.ReadLine().ToArray();

                char[] vowels = { 'A', 'a', 'E', 'e', 'U', 'u', 'I', 'i', 'O', 'o' };

                int vowelsSum = arr.Where(x => vowels.Contains(x)).Sum(x => x * arr.Length);
                int nonVowelsSum = arr.Where(x => !vowels.Contains(x)).Sum(x => x / arr.Length);

                arrSort[index] = vowelsSum + nonVowelsSum;
            }

            Console.WriteLine(string.Join(Environment.NewLine, arrSort.OrderBy(x => x)));
        }
    }
}
