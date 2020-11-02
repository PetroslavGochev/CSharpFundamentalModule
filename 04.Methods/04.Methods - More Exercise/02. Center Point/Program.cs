using System;

namespace _02._Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arrayOfClosestNumber = new double[2];
            Console.WriteLine($"({string.Join(", ", ReadNumberAndReturnArrayOfClosestNumber(arrayOfClosestNumber))})");
        }
        static double[] ReadNumberAndReturnArrayOfClosestNumber(double[] array)
        {
            double distance1 = 0;
            double distance2 = 0;
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            distance1 = Math.Pow(x, 2) + Math.Pow(y, 2);
            distance2 = Math.Pow(x1, 2) + Math.Pow(y1, 2);
            if (x == x1 && y == y1)
            {
                array[0] = x;
                array[1] = x1;
            }
            if (distance1 < distance2)
            {
                array[0] = x;
                array[1] = y;
            }
            else
            {
                array[0] = x1;
                array[1] = y1;
            }

            return array;
        }
    }
}
