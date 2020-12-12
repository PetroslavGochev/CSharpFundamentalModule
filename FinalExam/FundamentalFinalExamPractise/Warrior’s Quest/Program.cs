using System;

namespace Warrior_s_Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "For Azeroth")
            {
                var data = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var command = data[0];
                if (command == "GladiatorStance")
                {
                    text = UpperCase(text);
                    PrintText(text);
                }
                else if (command == "DefensiveStance")
                {
                    text = LowerCase(text);
                    PrintText(text);
                }
                else if (command == "Dispel")
                {
                    int index = int.Parse(data[1]);
                    char letter = char.Parse(data[2]);
                    if (IsIndexValid(text, index))
                    {
                        text = Replace(text, index, letter);
                    }
                    else
                    {
                        Console.WriteLine($"Dispel too weak.");
                    }
                }
                else if (command == "Target" && data[1] == "Change")
                {
                    string substring = data[2];
                    string replace = data[3];
                    text = ReplaceSubstring(text, substring, replace);
                    PrintText(text);
                }
                else if (command == "Target" && data[1] == "Remove")
                {
                    string substring = data[2];
                    text = RemoveSubstring(text, substring);
                    PrintText(text);
                }
                else
                {
                    Console.WriteLine("Command doesn't exist!");
                }
            }
        }
        static void PrintText(string text) => Console.WriteLine(text);
        static string UpperCase(string text) => text.ToUpper();
        static string LowerCase(string text) => text.ToLower();
        static string Replace(string text, int index, char replace)
        {
            char[] array = text.ToCharArray();
            array[index] = replace;
            Console.WriteLine("Success!");
            return new string(array);
        }
        static string ReplaceSubstring(string text, string substring, string replace) => text.Replace(substring, replace);
        static string RemoveSubstring(string text, string substring)
        {
            int index = text.IndexOf(substring);
            int length = substring.Length;
            text = text.Remove(index, length);
            return text;
        }
        static bool IsIndexValid(string text, int index) => index >= 0 && index < text.Length;

    }
}
