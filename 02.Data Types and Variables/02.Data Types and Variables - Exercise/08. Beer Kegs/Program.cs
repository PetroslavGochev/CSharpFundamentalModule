using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double maxVolume = double.MinValue;
            string name = "";
            double volume = 0.0;


            for (int i = 1; i <= number; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                volume = Math.PI * radius * radius * height;
                if (volume > maxVolume)
                {
                    maxVolume = volume;
                    name = model;
                }


            }
            Console.WriteLine(name);
        }
    }
}
