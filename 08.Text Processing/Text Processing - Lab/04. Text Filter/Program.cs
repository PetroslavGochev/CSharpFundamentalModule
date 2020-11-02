using System;
using System.Linq;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string textFromConsole = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                textFromConsole = textFromConsole.Replace(text[i], new string('*', text[i].Length));
            }

            Console.WriteLine(textFromConsole);
        }
    }
}
