using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02._Archery_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfPoints = Console.ReadLine()
                  .Split("|", StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse)
                  .ToList();
            int iskrenPoints = 0;
            string command;
            while((command = Console.ReadLine())!= "Game over")
            {
                string[] text = command
                    .Split("@", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string direction = text[0];
                if(direction == "Shoot Left")
                {
                    if(int.Parse(text[1]) >= 0 && int.Parse(text[1])<listOfPoints.Count)
                    {
                        iskrenPoints += LeftDirection(listOfPoints, int.Parse(text[1]), int.Parse(text[2]));
                    }            
                }
                else if(direction == "Shoot Right")
                {
                    if (int.Parse(text[1]) >= 0 && int.Parse(text[1]) < listOfPoints.Count)
                    {
                        iskrenPoints += RightDirection(listOfPoints, int.Parse(text[1]), int.Parse(text[2]));
                    }                   
                }
                else if(direction == "Reverse")
                {
                    listOfPoints.Reverse();
                }
            }
            Console.WriteLine(PrintResult(listOfPoints, iskrenPoints));

                
        }
        static int RightDirection(List<int> listOfPoints, int startIndex, int counter)
        {
            int iskrenPoints = 0;
            for (int i = startIndex; i < listOfPoints.Count; i++)
            {
               
                if(counter == 0)
                {
                    if(listOfPoints[i] < 5)
                    {
                        iskrenPoints += listOfPoints[i];
                        listOfPoints[i] = 0;
                        break ;
                    }
                    listOfPoints[i] -= 5;
                    iskrenPoints += 5;
                    break;
                }
                counter--;
                if (i == listOfPoints.Count - 1)
                {
                    i = -1;
                }
            }
            return iskrenPoints;
        }
        static int LeftDirection(List<int> listofPoints, int startIndex,int count)
        {
            int iskrenPoints = 0;
            for (int i = startIndex; i >= 0; i--)
            {
                
                if(count == 0)
                {
                    if(listofPoints[i] < 5)
                    {
                        iskrenPoints += listofPoints[i];
                        listofPoints[i] = 0;
                        break;
                    }
                    listofPoints[i] -= 5;
                    iskrenPoints += 5;
                    break;
                }
                count--;
                if (i == 0)
                {
                    i = listofPoints.Count;
                }

            }
            return iskrenPoints;
        }
        static string PrintResult(List<int> listOfPoints,int points)
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(string.Join(" - ", listOfPoints));
            result.Append($"Iskren finished the archery tournament with {points} points!");
            return result.ToString();
        }
        
    }
}
