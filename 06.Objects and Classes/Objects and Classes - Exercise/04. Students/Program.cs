using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<Student> listOfStudents = new List<Student>();
            for (int i = 0; i < number; i++)
            {
                string[] student = Console.ReadLine().Split().ToArray();
                Student newStudent = new Student(student[0], student[1], double.Parse(student[2]));
                listOfStudents.Add(newStudent);
            }
            listOfStudents = Student.OrderByGrade(listOfStudents);
            foreach (Student student in listOfStudents)
            {
                Console.WriteLine(student);
            }
        }
    }
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public Student(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }
        public static List<Student> OrderByGrade(List<Student> listOfStudents)
        {
            List<Student> newListOfStudents = listOfStudents.OrderByDescending(x => x.Grade).ToList();
            return newListOfStudents;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }

    }
}

