using System;

namespace _01._National_Court
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalPeople = int.Parse(Console.ReadLine()) + int.Parse(Console.ReadLine()) + int.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            if (people == 0)
            {
                Console.WriteLine($"Time needed: 0h.");
                return;
            }
            for (int i = 1; ; i++)
            {
                if (i % 4 == 0)
                {
                    continue;
                }
                people -= totalPeople;
                if(people <= 0)
                {
                    Console.WriteLine($"Time needed: {i}h.");
                    return;
                }
            }
        }
    }
}
