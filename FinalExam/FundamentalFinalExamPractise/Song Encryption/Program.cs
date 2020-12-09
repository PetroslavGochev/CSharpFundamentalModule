using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Song_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^(?<name>[A-Z][a-z\s\']+):(?<song>[\sA-Z]+)";
            string input = string.Empty;
            while((input = Console.ReadLine()) != "end")
            {
                StringBuilder sb = new StringBuilder();
                int key = 0;
                Match match = Regex.Match(input, pattern);
                if(match.Length == 0)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                sb.Append($"Successful encryption: ");
                string artist = match.Groups["name"].Value;
                string song = match.Groups["song"].Value;
                key = match.Groups["name"].Value.Length;
                foreach (var item in artist)
                {
                    key = match.Groups["name"].Value.Length;
                    if (item == '\'')
                    {
                        sb.Append("'");
                        continue;
                    }
                    if(item == ' ')
                    {
                        sb.Append(" ");
                        continue;
                    }
                    int number = (int)item;
                    while (key != 0)
                    {
                        number++;
                        if(number == 123)
                        {
                            number = 97;
                        }
                        key--;             
                    }
                    sb.Append($"{(char)number}");
                }
                sb.Append("@");
                foreach (var item in song)
                {
                    key = match.Groups["name"].Value.Length;
                    if (item == ' ')
                    {
                        sb.Append(" ");
                        continue;
                    }
                    int number = (int)item;
                    while (key != 0)
                    {
                        number++;
                        if (number == 91)
                        {
                            number = 65;
                        }
                        key--;
                    }
                    sb.Append($"{(char)number}");
                }          
               Console.WriteLine($"Successful encryption: {sb}");
            }
        }
    }
}
