using System;

namespace _01._SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentPerHour = int.Parse(Console.ReadLine()) + int.Parse(Console.ReadLine()) + int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            bool flag = true;
            if(students== 0)
            {
                Console.WriteLine($"Time needed: {0}h.");
                return;
            } 
            for (int i = 1; flag ; i++)
            {
                if(i % 4 == 0)
                {
                    continue;
                }
                if(students > studentPerHour)
                {
                    students -= studentPerHour;
                }
                else
                {
                    Console.WriteLine($"Time needed: {i}h.");
                    return;
                }

            }
        }
    }
}
