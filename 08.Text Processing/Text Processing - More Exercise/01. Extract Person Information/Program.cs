using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01._Extract_Person_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                string text = Console.ReadLine();
                int nameStartIndex = text.IndexOf('@')+1;
                int nameFinalIndex = text.IndexOf('|');
                int lenghtName = nameFinalIndex - nameStartIndex;
                int ageStartIndex = text.IndexOf('#')+1;
                int ageFinalIndex = text.IndexOf('*');
                int lenghtAge = ageFinalIndex - ageStartIndex;
                string name = text.Substring(nameStartIndex, lenghtName);
                string age = text.Substring(ageStartIndex, lenghtAge);
                Console.WriteLine($"{ name} is { age } years old.");     
            }
        }
    }
}
