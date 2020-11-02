using System;
using System.Linq;
using System.Text;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] url = Console.ReadLine()
                .Split("\\")
                .ToArray();
            Console.WriteLine(ReturnExtractFile(url));
        }
        static string ReturnExtractFile(string[] url)
        {
            string[] extractfile = url[url.Length - 1]
                .Split(".")
                .ToArray();
            StringBuilder file = new StringBuilder();
            file.AppendLine($"File name: {extractfile[0]}");
            file.Append($"File extension: {extractfile[1]}");
            return file.ToString();

        }
    }
}
