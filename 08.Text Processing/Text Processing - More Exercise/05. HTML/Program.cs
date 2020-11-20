using System;
using System.Text;

namespace _05._HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            string content = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            result.AppendLine("<h1>");
            result.AppendLine($"{title}");
            result.AppendLine($"</h1>");
            result.AppendLine($"<article>");
            result.AppendLine($"{content}");
            result.AppendLine($"</article>");
            string comments = string.Empty;
            while ((comments = Console.ReadLine()) != "end of comments")
            {
                result.AppendLine("<div>" + Environment.NewLine + $"{comments}" + Environment.NewLine + "</div>");      
            }
            Console.WriteLine(result.ToString().Trim());

        }
    }
}
