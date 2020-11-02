using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01._Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadInputFromConsole();
        }
        static void ReadInputFromConsole()
        {
            List<string> listOfNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string text = Console.ReadLine();
            Console.WriteLine(ReturnMessage(listOfNumbers, text));
        }
        static string ReturnMessage(List<string> listOfNumbers, string text)
        {

            List<char> arrayOfChar = text.ToList();
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                int sumOfElement = 0;
                foreach (var number in listOfNumbers[i])
                {
                    sumOfElement += int.Parse(number.ToString());
                }
                result.Append(WriteMessage(sumOfElement, arrayOfChar));
            }
            return result.ToString();
        }
        static char WriteMessage(int counter, List<char> arrayOfChar)
        {
            char symbol;
            for (int i = 0; i < arrayOfChar.Count; i++)
            {
                if (counter == 0)
                {
                    symbol = arrayOfChar[i];
                    arrayOfChar.RemoveAt(i);
                    return symbol;
                }
                if (i == arrayOfChar.Count - 1)
                {
                    i = -1;
                }
                counter--;
            }
            return arrayOfChar[0];
        }
    }
}
