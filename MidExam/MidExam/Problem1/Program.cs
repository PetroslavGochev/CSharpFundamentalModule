using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int biscuits = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            double other = int.Parse(Console.ReadLine());
           
            double biscuitsPerDay = biscuits * workers;
            double total = 0;
            for (int i = 1; i <= 30; i++)
            {
                if(i % 3 == 0)
                {
                    double thirdDay = biscuitsPerDay * 0.75;
                    total += Math.Floor(thirdDay);
                    continue;
                }
                total += biscuitsPerDay;
            }
            double difference = Math.Abs(total - other);
            double percent = difference/other * 100;
            Console.WriteLine($"You have produced {total} biscuits for the past month.");
            if (total > other)
            {
                Console.WriteLine($"You produce {percent:f2} percent more biscuits.");
            }
            else
            {
                Console.WriteLine($"You produce {percent:f2} percent less biscuits.");
            }
            
        }
    }
}
