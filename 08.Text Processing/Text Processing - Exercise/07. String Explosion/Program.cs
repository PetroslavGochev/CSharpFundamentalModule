using System;
using System.Linq;

namespace _07._String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine()
               .ToList();
            int strength = 0;
            int position = 0;
            for (int i = 0; i < text.Count; i++)
            {
                if (text[i] == '>')
                {
                    strength += int.Parse(text[i + 1].ToString());
                    continue;
                }
                if (strength > 0)
                {
                    text.RemoveAt(i);
                    strength--;
                    i--;
                }
            }
            Console.WriteLine(string.Join("", text));
        }
    }
}
