using System;

namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            while ((text = Console.ReadLine()) != "end")
            {
                Console.WriteLine($"{text} = {ReturnReverseString(text)}");
            }
        }
        static string ReturnReverseString(string text)
        {
            char[] array = text.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}
