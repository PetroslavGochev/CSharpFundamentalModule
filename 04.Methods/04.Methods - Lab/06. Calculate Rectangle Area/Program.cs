using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AreaRecangle(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())));
        }
        static double AreaRecangle(double height, double width)
        {
            return width * height;
        }
    }
}
