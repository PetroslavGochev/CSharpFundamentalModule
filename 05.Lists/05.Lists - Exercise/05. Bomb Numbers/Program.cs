using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static List<int> ReturnList()
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            return list;
        }
        static void Main(string[] args)
        {
            var list = ReturnList();
            var bombNumber = ReturnList();
            DeleteBombNumber(list, bombNumber);
            Console.WriteLine(ReturnSumOfList(list));

        }

        static List<int> DeleteBombNumber(List<int> list, List<int> bombNumber)
        {
            int bomb = bombNumber[0];
            int bombRange = bombNumber[1];
            int startIndex = 0;
            int finalIndex = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == bomb)
                {
                    startIndex = i - bombRange;
                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    finalIndex = i + bombRange;
                    if (finalIndex >= list.Count)
                    {
                        finalIndex = list.Count - 1;
                    }
                    list.RemoveRange(startIndex, finalIndex - startIndex + 1);
                    i = 0;
                }
            }
            return list;
        }


        static int ReturnSumOfList(List<int> list)
        {
            int sum = 0;
            foreach (int number in list)
            {
                sum += number;
            }
            return sum;
        }
    }
}
