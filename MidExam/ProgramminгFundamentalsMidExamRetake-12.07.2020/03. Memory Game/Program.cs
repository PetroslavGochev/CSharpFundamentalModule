using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Memory_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfElements = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .ToList();
            int moves = 0;
            string command;           
            while((command = Console.ReadLine())!= "end")
            {
                
                string[] text = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                moves++;
                int firstIndex = int.Parse(text[0]); 
                int secondIndex = int.Parse(text[1]); 
                if(firstIndex == secondIndex || firstIndex  < 0 || firstIndex >= listOfElements.Count || secondIndex <0 || secondIndex >= listOfElements.Count)
                {
                    Console.WriteLine($"Invalid input! Adding additional elements to the board");
                    firstIndex = listOfElements.Count / 2;
                    listOfElements.Insert(firstIndex,$"-{moves}a");
                    listOfElements.Insert(firstIndex,$"-{moves}a");
                    continue;
                }
                if(listOfElements[firstIndex] == listOfElements[secondIndex])
                {
                    string correctElement = listOfElements[firstIndex];
                    Console.WriteLine($"Congrats! You have found matching elements - {correctElement}!");
                    firstIndex = Math.Min(firstIndex, secondIndex);
                    secondIndex = Math.Max(firstIndex, secondIndex);
                    listOfElements.RemoveAt(secondIndex);
                    listOfElements.RemoveAt(firstIndex);
                }
                else
                {
                    Console.WriteLine("Try again!");
                }
                if(listOfElements.Count == 0)
                {
                    Console.WriteLine($"You have won in {moves} turns!");
                    return;
                }
            }
            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(string.Join(" ", listOfElements));
        }
    }
}
