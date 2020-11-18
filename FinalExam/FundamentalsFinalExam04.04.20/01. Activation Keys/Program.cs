using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            var activatKey = Console.ReadLine().ToList();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Generate")
            {
                var command = input.Split(">>>", StringSplitOptions.RemoveEmptyEntries);
                if (command[0] == "Contains")
                {
                    string criteria = command[1];

                    if (Contains(activatKey, criteria))
                    {
                        Console.WriteLine($"{string.Join("", activatKey)} contains {criteria}");
                    }

                }
                else if (command[0] == "Flip")
                {
                    var data = command.Skip(1).ToArray();
                    UpperOrLower(activatKey, data);
                    Console.WriteLine(string.Join("", activatKey));

                }
                else if (command[0] == "Slice")
                {
                    var data = command.Skip(1).ToArray();
                    Slice(activatKey, data);
                    Console.WriteLine(string.Join("", activatKey));
                }
            }
            Console.WriteLine($"Your activation key is: {string.Join("", activatKey)}");
        }
        static bool Contains(List<char> activatkey, string criteria)
        {
            foreach (var character in criteria)
            {
                if (!activatkey.Contains(character))
                {
                    Console.WriteLine("Substring not found!");
                    return false;
                }
            }
            return true;
        }
        static void UpperOrLower(List<char> activatkey, string[] data)
        {
            var upperLower = data[0];
            var startIndex = int.Parse(data[1]);
            var endIndex = int.Parse(data[2]);
            if (upperLower == "Upper")
            {
                for (int i = startIndex; i < endIndex; i++)
                {
                    activatkey[i] = char.Parse(activatkey[i].ToString().ToUpper());
                }
            }
            else
            {
                for (int i = startIndex; i < endIndex; i++)
                {
                    activatkey[i] = char.Parse(activatkey[i].ToString().ToLower());
                }
            }

        }
        static void Slice(List<char> activitiKey, string[] data)
        {
            var startIndex = int.Parse(data[0]);
            var endIndex = int.Parse(data[1]);
            activitiKey.RemoveRange(startIndex, endIndex - startIndex);
        }
    }
}
