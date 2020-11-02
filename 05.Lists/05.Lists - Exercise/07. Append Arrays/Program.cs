using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    class Program
    {
        static List<string> ReturnList()
        {
            List<string> list = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).Reverse().ToList();
            return list;
        }
        static void Main(string[] args)
        {
            var list = ReturnList();
            var finalList = ReturnFinalList(list);
            Console.WriteLine(string.Join(" ", finalList));


        }

        static List<int> ReturnFinalList(List<string> list)
        {
            List<int> finalList = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                finalList.AddRange(list[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            }
            return finalList;
        }

    }
}
