using System;
using System.Linq;

namespace _02._Ascii_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            int result = 0;
            foreach (var symbol in text)
            {
                if(symbol > first && symbol < second)
                {
                    result += symbol;
                }
            }
            Console.WriteLine(result);
        }
    }
}
