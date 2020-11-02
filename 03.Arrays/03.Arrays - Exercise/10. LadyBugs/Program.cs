using System;
using System.Linq;

namespace _10._LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] arrayOne = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] arrayTwo = new int[number];

            foreach (var index in arrayOne)
            {
                if (index >= 0 && index < arrayTwo.Length)
                {
                    arrayTwo[index] = 1;
                }
            }
            string text;
            while ((text = Console.ReadLine()) != "end")
            {
                string[] command = text.Split().ToArray();
                if (int.Parse(command[0]) >= arrayTwo.Length || int.Parse(command[0]) < 0 || arrayTwo[int.Parse(command[0])] == 0)
                {
                    continue;
                }
                if (int.Parse(command[2]) == 0)
                {
                    continue;
                }
                int j = 0;
                while (true)
                {
                    if (command[1] == "right")
                    {
                        if (int.Parse(command[0]) + int.Parse(command[2]) + j >= arrayTwo.Length)
                        {
                            arrayTwo[int.Parse(command[0])] = 0;
                            break;
                        }
                        else if (arrayTwo[int.Parse(command[0]) + int.Parse(command[2]) + j] == 0)
                        {
                            arrayTwo[int.Parse(command[0]) + int.Parse(command[2]) + j] = 1;
                            arrayTwo[int.Parse(command[0])] = 0;
                            break;
                        }
                        else
                        {
                            j += int.Parse(command[2]);
                            continue;
                        }
                    }
                    else if (command[1] == "left")
                    {
                        if (int.Parse(command[0]) - int.Parse(command[2]) - j < 0)
                        {
                            arrayTwo[int.Parse(command[0])] = 0;
                            break;
                        }
                        else if (arrayTwo[int.Parse(command[0]) - int.Parse(command[2]) - j] == 0)
                        {
                            arrayTwo[int.Parse(command[0]) - int.Parse(command[2]) - j] = 1;
                            arrayTwo[int.Parse(command[0])] = 0;
                            break;
                        }
                        else
                        {
                            j += int.Parse(command[2]);
                            continue;
                        }
                   }
                }
            }
            Console.WriteLine(String.Join(" ", arrayTwo));
        }
    }
}
