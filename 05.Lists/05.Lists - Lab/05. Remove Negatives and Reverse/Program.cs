using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            Console.WriteLine(String.Join(" ", ReverseList(RemoveNegativeNumbersInList(list))));

        }

        static List<int> RemoveNegativeNumbersInList(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < 0)
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
            if (list.Count == 0)
            {
                Console.WriteLine("empty");
            }
            return list;
        }
        static List<int> ReverseList(List<int> list)
        {
            list.Reverse();
            return list;
        }
    }
}
