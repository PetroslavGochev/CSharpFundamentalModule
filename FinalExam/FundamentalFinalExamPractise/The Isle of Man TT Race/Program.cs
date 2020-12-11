using System;
using System.Text;
using System.Text.RegularExpressions;

namespace The_Isle_of_Man_TT_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(#|\$|\%|\*|&)(?<name>[A-Za-z]+)\1=(?<length>[\d]+)!!(?<code>.+)";
            while (true)
            {
                Match match = Regex.Match(Console.ReadLine(), pattern);
                if(match.Length == 0)
                {
                    Message();
                    continue;
                }
                int length = int.Parse(match.Groups["length"].Value);
                int codeLength = match.Groups["code"].Value.Length;
                if(length != codeLength)
                {
                    Message();
                    continue;              
                }
                StringBuilder sb = new StringBuilder();
                foreach (var character in match.Groups["code"].Value)
                {
                    sb.Append((char)(character + length));
                }
                Console.WriteLine($"Coordinates found! { match.Groups["name"].Value} -> { sb}");
                return;
            }
        }
         static void Message() => Console.WriteLine("Nothing found!");
    }
}
