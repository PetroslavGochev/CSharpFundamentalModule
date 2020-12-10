using System;
using System.Text;

namespace Username
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Sign up")
            {
                var data = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var command = data[0];
                if (command == "Case")
                {
                    string lowerOrUpper = data[1];
                    if (lowerOrUpper == "lower")
                    {
                        username = LowerCase(username);
                    }
                    else
                    {
                        username = UpperCase(username);
                    }
                    Console.WriteLine(username);
                }
                else if (command == "Reverse")
                {
                    int startIndex = int.Parse(data[1]);
                    int endIndex = int.Parse(data[2]);
                    if (IsValid(startIndex, username.Length) && IsValid(endIndex, username.Length))
                    {
                        string substring = username.Substring(startIndex, endIndex - startIndex + 1);
                        char[] text = substring.ToCharArray();
                        Array.Reverse(text);
                        Console.WriteLine(string.Join("", text)) ;
                    }
                }
                else if (command == "Cut")
                {
                    string substring = data[1];
                    username = Cut(username, substring);
                }
                else if(command == "Replace")
                {
                    char symbol = char.Parse(data[1]);
                    username = Replace(username, symbol);
                    Console.WriteLine(username);
                }
                else if(command == "Check")
                {
                    char symbol = char.Parse(data[1]);
                    if (Check(username, symbol))
                    {
                        Console.WriteLine("Valid");
                    }
                    else
                    {
                        Console.WriteLine($"Your username must contain {symbol}.");
                    }
                }
            }
        }
        static string LowerCase(string username) => username.ToLower();
        static string UpperCase(string username) => username.ToUpper();
        static bool IsValid(int index, int length) => index >= 0 && index < length;
        static string Cut(string username, string substring)
        {

            if (username.Contains(substring))
            {
              username = username.Replace(substring, "");
                Console.WriteLine($"{username}");
            }
            else
            {
                Console.WriteLine($"The word {username} doesn't contain {substring}.");
            }
            return username;
        }
        static string Replace(string username, char symbol) => username.Replace(symbol, '*');
        static bool Check(string username, char symbol) => username.Contains(symbol);

    }
}
