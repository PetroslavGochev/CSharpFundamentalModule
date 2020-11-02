using System;

namespace _06._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 97; i < 97 + number; i++)
            {
                for (int k = 97; k < 97 + number; k++)
                {
                    for (int j = 97; j < 97 + number; j++)
                    {

                        Console.WriteLine($"{(char)i}{(char)k}{(char)j}");
                    }
                }
            }
        }
    }
}
