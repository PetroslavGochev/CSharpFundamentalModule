
using System;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(5>'a');

            string text = Console.ReadLine();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Done")
            {
                var data = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var command = data[0];
                if (command == "Change")
                {
                    char symbol = char.Parse(data[1]);
                    char replace = char.Parse(data[2]);
                    text = Change(text, symbol, replace);
                    Console.WriteLine(text);
                }
                else if (command == "Includes")
                {
                    string includes = data[1];
                    Console.WriteLine(Includes(text, includes));
                }
                else if (command == "End")
                {
                    string textEnd = data[1];
                    Console.WriteLine(End(text, textEnd));
                }
                else if (command == "Uppercase")
                {
                    text = Uppercase(text);
                    Console.WriteLine(text);
                }
                else if (command == "FindIndex")
                {
                    char character = char.Parse(data[1]);
                    Console.WriteLine(FindIndex(text, character));
                }
                else if (command == "Cut")
                {
                    int start = int.Parse(data[1]);
                    int length = int.Parse(data[2]);
                    text = CutIndex(text, start, length);
                    Console.WriteLine(text);
                }
            }
        }
        static string Change(string text, char symbol, char replace) => text.Replace(symbol, replace);
        static bool Includes(string text, string textInclude) => text.Contains(textInclude);
        static string Uppercase(string text) => text.ToUpper();
        static bool End(string text, string textEnd) => text.EndsWith(textEnd);

        static int FindIndex(string text, char character) => text.IndexOf(character);
        static string CutIndex(string text, int start, int length) => text.Substring(start, length);
    }
}
