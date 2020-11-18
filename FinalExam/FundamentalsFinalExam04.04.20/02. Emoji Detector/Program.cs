using System;
using System.Text.RegularExpressions;

namespace _02._Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberPattern = @"[\d]";
            string pattern = @"(\*\*[A-Z]{1}[a-z]{2,}\*\*|\:\:[A-Z]{1}[a-z]{2,}\:\:)";
            string text = Console.ReadLine();
            int sum = 1;
            MatchCollection number = Regex.Matches(text, numberPattern);
            MatchCollection emoji = Regex.Matches(text, pattern);
            foreach (Match digit in number)
            {
                int num = int.Parse(digit.Value);
                sum *= num;
            }
            Console.WriteLine($"Cool threshold: {sum}");
            Console.WriteLine($"{emoji.Count} emojis found in the text. The cool ones are:");
            foreach (Match item in emoji)
            {
                int sumOfEmoji = 0;
                foreach (var character in item.Value)
                {
                    if(character == ':' || character == '*')
                    {
                        continue;
                    }
                    sumOfEmoji += character;
                }
                if (sumOfEmoji >= sum)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
