using System;

namespace Nikulden_s_Charity
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Finish")
            {
                var data = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var command = data[0];
                if (command == "Replace")
                {
                    var oldChar = char.Parse(data[1]);
                    var newChar = char.Parse(data[2]);
                    text = Replace(text, oldChar, newChar);
                    PrintString(text);
                }
                else if(command == "Cut")
                {
                    int startIndex = int.Parse(data[1]);
                    int endIndex = int.Parse(data[2]);
                    if(IsIndexValid(text.Length,startIndex) && IsIndexValid(text.Length,endIndex))
                    {
                        text = Cut(text, startIndex, endIndex - startIndex + 1 );
                        PrintString(text);
                        continue;
                    }
                    InvalidIndex();
                }
                else if (command == "Make")
                {
                    var upperOrLower = data[1];
                    if(upperOrLower == "Lower")
                    {
                        text = Lower(text);
                    }
                    else if(upperOrLower == "Upper")
                    {
                        text = Upper(text);
                    }
                    PrintString(text);
                }
                else if (command == "Check")
                {
                    string contains = data[1];
                    if (IsContains(text, contains))
                    {
                        Console.WriteLine($"Message contains {contains}");
                        continue;
                    }
                    Console.WriteLine($"Message doesn't contain {contains}");
                }
                else if (command == "Sum")
                {
                    int startIndex = int.Parse(data[1]);
                    int endIndex = int.Parse(data[2]);
                    if (IsIndexValid(text.Length, startIndex) && IsIndexValid(text.Length, endIndex))
                    {
                        Console.WriteLine(SumOfAscii(text, startIndex, endIndex)) ;
                        continue;
                    }
                    InvalidIndex();
                }
            }
        }
         public static string Replace(string text, char old, char newChar) => text.Replace(old, newChar);
        public static string Cut(string text, int start, int length) => text.Remove(start, length);
        public static bool IsIndexValid(int length, int index) => index >= 0 && index < length;
        public static string Upper(string text) => text.ToUpper();
        public static string Lower(string text) => text.ToLower();
        public static bool IsContains(string text, string contains) => text.Contains(contains);
        public static void InvalidIndex() => Console.WriteLine("Invalid indexes!");
        public static int SumOfAscii(string text,int start, int end)
        {
            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                sum += (int)text[i];
            }
            return sum;
        }
        public static void PrintString(string text) => Console.WriteLine(text);
    }
}
