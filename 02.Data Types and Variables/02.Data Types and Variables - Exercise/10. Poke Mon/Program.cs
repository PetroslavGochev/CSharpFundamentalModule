using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int target = 0;
            double percent = N * 0.5;

            while (N >= M)
            {

                N -= M;
                target++;
                if (N == percent && Y != 0)
                {
                    N /= Y;
                }
            }
            Console.WriteLine(N);
            Console.WriteLine(target);
        }
    }
}
