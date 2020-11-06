using System;

namespace _01._Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            double students = double.Parse(Console.ReadLine());
            double lectures = double.Parse(Console.ReadLine());
            double bonus = double.Parse(Console.ReadLine());
            double maxBonus = 0;
            double maxLectures = 0;
            for (int i = 1; i <= students; i++)
            {
                double student = double.Parse(Console.ReadLine());
                double sum = (student / lectures) * (5 + bonus);
                if(sum > maxBonus)
                {
                    maxBonus = sum;
                    maxLectures = student;
                }
            }
            Console.WriteLine($"Max Bonus: {Math.Round(maxBonus)}.");
            Console.WriteLine($"The student has attended {maxLectures} lectures.");
        }
    }
}
