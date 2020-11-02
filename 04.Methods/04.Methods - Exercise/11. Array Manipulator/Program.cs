using System;
using System.Linq;

namespace _11._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                  .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse)
                  .ToArray();
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandArray = command.Split().ToArray();
                if (commandArray[0] == "exchange")
                {
                    if (int.Parse(commandArray[1]) >= array.Length || int.Parse(commandArray[1]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        ReturnExchangeArray(array, int.Parse(commandArray[1]));
                    }
                }
                if (commandArray[0] == "max" || commandArray[0] == "min")
                {
                    ReturnIndexOfMaxOrMinDigit(array, commandArray[0], commandArray[1]);
                }
                if (commandArray[0] == "first" || commandArray[0] == "last")
                {
                    if (int.Parse(commandArray[1]) > array.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        ReturnFirstOrLastDigit(array, commandArray[0], commandArray[2], int.Parse(commandArray[1]));
                    }
                }
            }
            Console.WriteLine($"[{String.Join(", ", array)}]");
            static int[] ReturnExchangeArray(int[] array, int index)
            {
                int temp = 0;
                for (int i = 0; i <= index; i++)
                {
                    for (int k = 0; k < array.Length - 1; k++)
                    {
                        temp = array[k];
                        array[k] = array[k + 1];
                        array[k + 1] = temp;
                    }
                }
                return array;
            }
            static void ReturnIndexOfMaxOrMinDigit(int[] array, string maxOrMin, string oddOrEven)
            {
                int maxNumber = int.MinValue;
                int minNumber = int.MaxValue;
                int index = -1;
                for (int i = 0; i < array.Length; i++)
                {
                    if (maxOrMin == "max" && oddOrEven == "odd" && array[i] % 2 != 0 && array[i] >= maxNumber)
                    {
                        maxNumber = array[i];
                        index = i;

                    }
                    else if (maxOrMin == "max" && oddOrEven == "even" && array[i] % 2 == 0 && array[i] >= maxNumber)
                    {
                        maxNumber = array[i];
                        index = i;
                    }
                    else if (maxOrMin == "min" && oddOrEven == "odd" && array[i] % 2 != 0 && array[i] <= minNumber)
                    {
                        minNumber = array[i];
                        index = i;

                    }
                    else if (maxOrMin == "min" && oddOrEven == "even" && array[i] % 2 == 0 && array[i] <= minNumber)
                    {
                        minNumber = array[i];
                        index = i;
                    }
                }
                if (index >= 0)
                {
                    Console.WriteLine(index);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
            static void ReturnFirstOrLastDigit(int[] array, string lastOrFirst, string oddOrEven, int index)
            {
                string numbers = string.Empty;
                if (lastOrFirst == "first")
                {
                    foreach (int digit in array)
                    {
                        if (index == 0)
                        {
                            break;
                        }
                        if (oddOrEven == "even" && digit % 2 == 0)
                        {
                            numbers += $"{digit} ";
                            index--;
                        }
                        else if (oddOrEven == "odd" && digit % 2 != 0)
                        {
                            numbers += $"{digit} ";
                            index--;
                        }
                    }
                }
                else if (lastOrFirst == "last")
                {
                    for (int i = array.Length - 1; i >= 0; i--)
                    {

                        if (index == 0)
                        {
                            break;
                        }
                        if (oddOrEven == "even" && array[i] % 2 == 0)
                        {
                            numbers += $"{array[i]} ";
                            index--;


                        }
                        else if (oddOrEven == "odd" && array[i] % 2 != 0)
                        {
                            numbers += $"{array[i]} ";
                            index--;
                        }
                    }
                }
                string[] finalArrays = numbers.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (finalArrays.Length == 0)
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    if (lastOrFirst == "last")
                    {
                        Array.Reverse(finalArrays);
                    }
                    Console.WriteLine($"[{String.Join(", ", finalArrays)}]");
                }
            }
        }
    }
}
