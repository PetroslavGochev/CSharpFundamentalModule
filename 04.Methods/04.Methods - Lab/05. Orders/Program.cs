using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = (Console.ReadLine());
            int quantity = int.Parse(Console.ReadLine());
            if (product == "water")
            {
                Water(quantity);
            }
            else if (product == "coke")
            {
                Coke(quantity);
            }
            else if (product == "coffee")
            {
                Coffee(quantity);
            }
            else
            {
                Snacks(quantity);
            }
        }
        static void Coke(int quantity)
        {
            double result = quantity * 1.40;
            Console.WriteLine($"{result:f2}");
        }
        static void Water(int quantity)
        {
            double result = quantity * 1;
            Console.WriteLine($"{result:f2}");
        }
        static void Coffee(int quantity)
        {
            double result = quantity * 1.50;
            Console.WriteLine($"{result:f2}");
        }
        static void Snacks(int quantity)
        {
            double result = quantity * 2.00;
            Console.WriteLine($"{result:f2}");
        }
    }
}
