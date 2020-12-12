using System;

namespace Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string input = string.Empty;
            while((input = Console.ReadLine()) != "Reveal")
            {
                var data = input
                    .Split(":|:", StringSplitOptions.RemoveEmptyEntries);
                var command = data[0];
                if(command == "InsertSpace")
                {
                    int index = int.Parse(data[1]);
                    text = InsertSpace(text, index);
                }
                else if(command == "Reverse")
                {
                    string substring = data[1];
                    if (Contains(text, substring))
                    {
                        text = ReverseSubstring(text, substring);
                    }
                    else
                    {
                        Console.WriteLine($"error");
                        continue;
                    }
                }
                else if (command == "ChangeAll")
                {
                    string substring = data[1];
                    string replacement = data[2];
                    text = ChangeAll(text, substring, replacement);
                }
                PrintResult(text);
            }
            PrintMessage(text);
        }
        static void PrintResult(string text) => Console.WriteLine(text);
        static string InsertSpace(string text,int index)
        {
            text = text.Insert(index, " ");
            return text;
        }
        static string ReverseSubstring(string text,string substring)
        {
            char[] reverse = substring.ToCharArray();
            Array.Reverse(reverse);
            int index = text.IndexOf(substring);
            int length = substring.Length;
            text = text.Remove(index,length);
            text = text.Insert(text.Length, new string(reverse));
            return text;
            
        }
        static string ChangeAll(string text, string substring, string replacement) => text.Replace(substring, replacement);
        static bool Contains(string text, string substring) => text.Contains(substring);
        static void PrintMessage(string text) => Console.WriteLine($"You have a new text message: {text}");
    }
}
