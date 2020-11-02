using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Car_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadDataFromConsole();
        }
        static void ReadDataFromConsole()
        {
            int[] arraysOfNumber = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            List<int> leftTime = new List<int>();
            List<int> rightTime = new List<int>();
            int finalIndex = arraysOfNumber.Length / 2;
            for (int i = 0; i < arraysOfNumber.Length; i++)
            {
                if (i < finalIndex)
                {
                    leftTime.Add(arraysOfNumber[i]);
                }
                else if (i > finalIndex)
                {
                    rightTime.Add(arraysOfNumber[i]);
                }
            }
            rightTime.Reverse();
            double left = CalculateTime(leftTime);
            double right = CalculateTime(rightTime);
            PrintBestTime(left, right);

        }
        static double CalculateTime(List<int> list)
        {
            double time = 0;
            foreach (var number in list)
            {
                time += number;
                if (number == 0)
                {
                    time *= 0.8;
                }
            }
            return time;
        }
        static void PrintBestTime(double leftTime, double rightTime)
        {
            if (leftTime < rightTime)
            {
                Console.WriteLine($"The winner is left with total time: {leftTime}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {rightTime}");
            }

        }

    }
}
