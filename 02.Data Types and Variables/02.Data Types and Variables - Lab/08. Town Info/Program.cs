using System;

namespace _08._Town_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
            short area = short.Parse(Console.ReadLine());

            Console.WriteLine($"Town {city} has population of {population} and area {area} square km.");
        }
    }
}
