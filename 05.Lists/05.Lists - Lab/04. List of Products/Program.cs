using System;
using System.Collections.Generic;

namespace _04._List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintListIndex(ReturnNewList(number));
        }

        static List<string> ReturnNewList(int number)
        {
            List<String> newList = new List<String>();

            for (int i = 0; i < number; i++)
            {
                newList.Add(Console.ReadLine());
            }
            return newList;
        }
        static void PrintListIndex(List<string> list)
        {
            list.Sort();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{list[i]}");
            }
        }
    }
}
