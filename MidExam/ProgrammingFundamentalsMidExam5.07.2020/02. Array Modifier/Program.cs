using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfInteger = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string input = string.Empty;
            while((input = Console.ReadLine()) != "end")
            {
                string[] command = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if(command[0] == "swap")
                {
                    SwapIndex(listOfInteger, int.Parse(command[1]), int.Parse(command[2]));
                }
                else if ( command[0] == "multiply")
                {
                    Multiply(listOfInteger, int.Parse(command[1]), int.Parse(command[2]));
                }
                else if (command[0] == "decrease")
                {
                    listOfInteger = listOfInteger.Select(x => x - 1).ToList();
                }
            }
            Console.WriteLine(string.Join(", ", listOfInteger));
        }
        static void SwapIndex (List<int> listOfInteger, int firstIndex , int secondIndex)
        {
            int temp = listOfInteger[firstIndex];
            listOfInteger[firstIndex] = listOfInteger[secondIndex];
            listOfInteger[secondIndex] = temp;
        }
        static void Multiply(List<int> listOfInteger,int firstIndex,int secondIndex)
        {
            listOfInteger[firstIndex] = listOfInteger[firstIndex] * listOfInteger[secondIndex];
        }
    }
}
