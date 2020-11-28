using System;
using System.Text;

namespace _01._World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder(Console.ReadLine());
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Travel")
            {
                var data = input
                    .Split(":", StringSplitOptions.RemoveEmptyEntries);
                var command = data[0];
                if (command == "Add Stop")
                {
                    var index = int.Parse(data[1]);
                    var str = data[2];
                    if (text.Length > index)
                    {
                        text.Insert(index, str);
                    }
                    Console.WriteLine(text);
                }
                else if (command == "Remove Stop")
                {
                    var startIndex = int.Parse(data[1]);
                    var endIndex = int.Parse(data[2]);
                    if (startIndex >= 0 && startIndex < text.Length && endIndex >= 0 && endIndex < text.Length)
                    {
                        text.Remove(startIndex, endIndex - startIndex + 1);
                    }
                    Console.WriteLine(text);
                }
                else if (command == "Switch")
                {
                    var oldString = data[1];
                    var newString = data[2];
                    if (text.ToString().Contains(oldString))
                    {
                        text.Replace(oldString, newString);
                    }
                    Console.WriteLine(text);
                }
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {text}");

        }
    }
}
