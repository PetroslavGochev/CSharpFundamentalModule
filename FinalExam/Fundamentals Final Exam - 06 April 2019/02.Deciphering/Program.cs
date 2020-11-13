using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.Deciphering
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder result = new StringBuilder();
            string firstText = Console.ReadLine();
            string[] secondText = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string pattern = @"^[d-z{ }|#]+\b";
            Match match = Regex.Match(firstText, pattern);
            if(match.Length == 0)
            {
                Console.WriteLine("This is not the book you are looking for.");
                return;
            }          
            for (int i = 0; i < firstText.Length; i++)
            {
                result.Append((char)(firstText[i] - 3)).ToString();
            }
            result.Replace(secondText[0], secondText[1]);
            Console.WriteLine(result.ToString());
        }
    }
}
