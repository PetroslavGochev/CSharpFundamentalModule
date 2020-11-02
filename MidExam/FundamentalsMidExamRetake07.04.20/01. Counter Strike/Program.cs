using System;

namespace _01._Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            string distance = string.Empty;
            int round = 0;
            int won = 0;
            while((distance = Console.ReadLine()) != "End of battle")
            {
                int enemy = int.Parse(distance);
                if(energy >= enemy)
                {
                    energy -= enemy;
                    won++;
                    round++;
                    if (round % 3 == 0)
                    {
                        energy +=won;
                    }
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {won} won battles and {energy} energy");
                    return;
                }
            }
            Console.WriteLine($"Won battles: {won}. Energy left: {energy}");
        }
    }
}
