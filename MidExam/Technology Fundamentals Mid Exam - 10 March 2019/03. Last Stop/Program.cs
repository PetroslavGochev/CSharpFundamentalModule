using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _03._Last_Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfPaint = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] arrayOfCommand = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string action = arrayOfCommand[0];
                if (action == "Change")
                {
                    ChangeNumberOfPaint(listOfPaint, int.Parse(arrayOfCommand[2]), int.Parse(arrayOfCommand[1]));
                }
                else if (action == "Hide")
                {
                    HidePaintFromList(listOfPaint, int.Parse(arrayOfCommand[1]));
                }
                else if (action == "Switch")
                {
                    SwitchPlaceOFPaintNumber(listOfPaint, int.Parse(arrayOfCommand[1]), int.Parse(arrayOfCommand[2]));
                }
                else if (action == "Insert")
                {
                    if (int.Parse(arrayOfCommand[1]) >= 0 && int.Parse(arrayOfCommand[1]) < listOfPaint.Count)
                    {
                        InsertPaintInList(listOfPaint, int.Parse(arrayOfCommand[2]), int.Parse(arrayOfCommand[1]));
                    }
                }
                else if (action == "Reverse")
                {
                    listOfPaint.Reverse();
                }
            }
            PrintResult(listOfPaint);
        }
        static void ChangeNumberOfPaint(List<int> listOfPaint, int newPaintNumber, int oldPaintNumebr)
        {
            for (int i = 0; i < listOfPaint.Count; i++)
            {
                if (listOfPaint[i] == oldPaintNumebr)
                {
                    listOfPaint[i] = newPaintNumber;
                    break;
                }
            }
        }
        static void HidePaintFromList(List<int> listOfPaint, int paintNumber)
        {
            if (listOfPaint.Contains(paintNumber))
            {
                listOfPaint.Remove(paintNumber);
            }

        }
        static void SwitchPlaceOFPaintNumber(List<int> listOFPaint, int firstPaint, int secondPaint)
        {
            if (listOFPaint.Contains(firstPaint) && listOFPaint.Contains(secondPaint))
            {
                int indexFirstElement = listOFPaint.FindIndex(x => x.Equals(firstPaint));
                int indexSecondElement = listOFPaint.FindIndex(x => x.Equals(secondPaint));
                int temp = listOFPaint[indexFirstElement];
                listOFPaint[indexFirstElement] = listOFPaint[indexSecondElement];
                listOFPaint[indexSecondElement] = temp;
            }
        }
        static void InsertPaintInList(List<int> listOfPaint, int paint, int index)
        {
            listOfPaint.Insert(index + 1, paint);
        }
        static void PrintResult(List<int> listOfPaint)
        {
            Console.WriteLine(string.Join(" ", listOfPaint));
        }
    }
}
