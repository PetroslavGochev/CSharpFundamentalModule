using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacityOfEleveator = int.Parse(Console.ReadLine());
            int course = 0;
            while (numberOfPeople > 0)
            {
                numberOfPeople -= capacityOfEleveator;
                course++;
            }
            Console.WriteLine(course);
        }
    }
}
