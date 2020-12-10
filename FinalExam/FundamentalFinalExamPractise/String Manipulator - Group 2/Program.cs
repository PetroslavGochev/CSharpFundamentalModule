using System;

namespace String_Manipulator___Group_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                var data = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var command = data[0];
                if (command == "Change")
                {
                    char old = char.Parse(data[1]);
                    char replace = char.Parse(data[2]);
                    text = text.Replace(old, replace);
                    Console.WriteLine(text);
                }
                else if (command == "Includes")
                {
                    string include = data[1];
                    Console.WriteLine(text.Contains(include));
                }
                else if (command == "Uppercase")
                {
                    text = text.ToUpper();
                    Console.WriteLine(text);
                }
                else if (command == "FindIndex")
                {
                    char character = char.Parse(data[1]);
                    Console.WriteLine(text.IndexOf(character));
                }
                else if (command == "End")
                {
                    string end = data[1];
                    int length = end.Length;
                    Console.WriteLine(end == text.Substring(text.Length - length, length));
                }
                else if (command == "Cut")
                {
                    int startIndex = int.Parse(data[1]);
                    int count = int.Parse(data[2]);
                    string substring = text.Substring(startIndex, count);
                    text = text.Replace(substring, "");
                    Console.WriteLine(substring);
                }
            }
        }
    }
}
