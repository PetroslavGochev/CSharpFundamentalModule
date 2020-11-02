using System;
using System.Text;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int time = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatString(text, time));
        }

        private static string RepeatString(string text, int time)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 1; i <= time; i++)
            {
                result.Append(text);
            }
            return result.ToString();
        }
    }
}
