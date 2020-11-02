using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            GetCharacterBetweenStartAndEnd(start, end);
        }
        static void GetCharacterBetweenStartAndEnd(char start, char end)
        {
            if (end < start)
            {
                char y = start;
                start = end;
                end = y;
            }
            for (char i = start; i < end; i++)
            {
                if (i == start)
                {
                    continue;
                }
                Console.Write($"{i} ");
            }
        }
    }
}
