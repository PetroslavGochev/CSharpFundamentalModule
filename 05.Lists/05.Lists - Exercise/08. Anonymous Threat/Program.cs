using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08._Anonymous_Threat
{
    class Program
    {
        static List<string> ReturnList()
        {
            List<string> list = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            return list;
        }
        static void Main(string[] args)
        {
            var list = ReturnList();

            Console.WriteLine(string.Join(" ", ReceiveCommand(list)));


        }

        static List<string> ReceiveCommand(List<string> list)
        {
            string command;
            while ((command = Console.ReadLine()) != "3:1")
            {
                string[] arrayCommand = command.Split().ToArray();
                if (arrayCommand[0] == "merge")
                {
                    ReturnMergeList(list, int.Parse(arrayCommand[1]), int.Parse(arrayCommand[2]));
                }
                else if (arrayCommand[0] == "divide")
                {
                    ReturnDivideList(list, int.Parse(arrayCommand[1]), int.Parse(arrayCommand[2]));
                }

            }
            return list;
        }
        static List<string> ReturnMergeList(List<string> list, int startIndex, int finalIndex)
        {
            StringBuilder text = new StringBuilder();

            if (startIndex < 0)
            {
                startIndex = 0;
            }
            else if (startIndex > list.Count - 1)
            {
                startIndex = (list.Count - 1) - 1;
            }
            if (finalIndex < 0)
            {
                finalIndex = 1;
            }
            if (finalIndex > list.Count - 1)
            {
                finalIndex = list.Count - 1;
            }

            for (int i = startIndex; i <= finalIndex; i++)
            {
                text.Append(list[startIndex]);
                list.Remove(list[startIndex]);
            }
            list.Insert(startIndex, text.ToString());
            return list;

        }
        static List<string> ReturnDivideList(List<string> list, int startIndex, int partitions)
        {
            string stringInStartIndex = list[startIndex];
            double counter = stringInStartIndex.Length / partitions;
            int rest = stringInStartIndex.Length % partitions;

            List<char> listOfChar = new List<char>();
            StringBuilder newString = new StringBuilder();

            for (int k = 0; k < stringInStartIndex.Length; k++)
            {
                listOfChar.Add(stringInStartIndex[k]);
            }
            for (int i = 0; i < partitions; i++)
            {
                if (i == partitions - 1)
                {
                    counter += rest;
                }
                for (int k = 0; k < counter; k++)
                {
                    newString.Append(listOfChar[0]);
                    listOfChar.Remove(listOfChar[0]);
                }
                list.Insert(startIndex + i, newString.ToString());
                newString.Remove(0, newString.Length);
            }

            list.Remove(stringInStartIndex);
            return list;
        }
    }
}
