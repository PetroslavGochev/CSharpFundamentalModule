using System;

namespace _01._Convert_Meters_to
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            double kilometers = (double)meters * 0.001;
            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
