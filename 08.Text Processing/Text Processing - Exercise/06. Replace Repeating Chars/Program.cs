using System;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int position = 0;
            int counter = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (i + 1 >= text.Length)
                {
                    text = text.Remove(position, counter);
                }

                else if (text[i] != text[i + 1] || i + 1 > text.Length)
                {
                    text = text.Remove(position, counter);
                    counter = 0;
                    position++;
                    i = position - 1;
                }
                else if (text[i] == text[i + 1])
                {
                    counter++;
                }
            }
            Console.WriteLine(text); 
        }
    }
}
