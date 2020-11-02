using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> dictionaryOfStudents = new Dictionary<string, List<double>>();
            int number = int.Parse(Console.ReadLine());
            PrintResult(ReceiveStudents(number, dictionaryOfStudents));
        }

        static Dictionary<string, double> ReceiveStudents(int number, Dictionary<string, List<double>> students)
        {
            for (int i = 1; i <= number; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());
                if (students.ContainsKey(studentName))
                {
                    students[studentName][0] += studentGrade;
                    students[studentName][1]++;
                }
                else
                {
                    students.Add(studentName, new List<double>());
                    students[studentName].Add(studentGrade);
                    students[studentName].Add(1);
                }
            }
            return CreateListOfStudents(students);

        }
        static Dictionary<string, double> CreateListOfStudents(Dictionary<string, List<double>> students)
        {
            Dictionary<string, double> studentsList = new Dictionary<string, double>();
            foreach (var student in students)
            {
                double average = student.Value[0] / student.Value[1];
                if (average >= 4.50)
                {
                    studentsList.Add(student.Key, average);
                }
            }
            studentsList = studentsList.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            return studentsList;
        }
        static void PrintResult(Dictionary<string, double> studentsList)
        {
            foreach (var student in studentsList)
            {
                Console.WriteLine($"{student.Key} -> {student.Value:f2}");
            }
        }
    }
}
