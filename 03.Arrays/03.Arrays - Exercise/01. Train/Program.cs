using System;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int[] train = new int[number];
            int totalPeople = 0;

            for (int i = 0; i < number; i++)
            {
                train[i] = int.Parse(Console.ReadLine());
                totalPeople += train[i];
            }
            for (int i = 0; i < number; i++)
            {
                Console.Write($"{train[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine($"{totalPeople}");
        }
    }
}
