using System;

namespace String_Manipulator___Group_1
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
                if (command == "Translate")
                {
                    char old = char.Parse(data[1]);
                    char replace = char.Parse(data[2]);
                    text = text.Replace(old, replace);
                   Console.WriteLine(text);
                }
                else if (command == "Include")
                {
                    string include = data[1];
                    Console.WriteLine(text.Contains(include));
                }
                else if (command == "Lowercase")
                {
                   text = text.ToLower();
                    Console.WriteLine(text);
                }
                else if (command == "FindIndex")
                {
                    char character = char.Parse(data[1]);
                    Console.WriteLine(text.LastIndexOf(character));
                }
                else if (command == "Start")
                {
                    string start = data[1];
                    int length = start.Length;
                    Console.WriteLine(start == text.Substring(0, length));     
                }
                else if(command == "Remove")
                {
                    int startIndex = int.Parse(data[1]);
                    int count = int.Parse(data[2]);
                    string substring = text.Substring(startIndex, count);
                    text = text.Replace(substring, "");
                    Console.WriteLine(text);
                }
            }
        }
    }
}
