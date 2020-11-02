using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Students_2._0
{
    class Program
    {
        public static void Main(string[] args)
        {
            string data;
            List<Student> students = new List<Student>();
            while ((data = Console.ReadLine()) != "end")
            {
                string[] dataOfStudents = data.Split().ToArray();
                string firstName = dataOfStudents[0];
                string lastName = dataOfStudents[1];
                int age = int.Parse(dataOfStudents[2]);
                string homeTown = dataOfStudents[3];
                if (IsStudentExisting(students, firstName, lastName))
                {
                    Student person = GetStudent(students, firstName, lastName);
                    person.Age = age;
                    person.HomeTown = homeTown;
                }
                else
                {
                    Student person = new Student();
                    person.FirstName = firstName;
                    person.LastName = lastName;
                    person.Age = age;
                    person.HomeTown = homeTown;
                    students.Add(person);
                }

            }
            string town = Console.ReadLine();
            List<Student> filteredStudents = students
                .Where(s => s.HomeTown == town)
                .ToList();

            foreach (Student student in filteredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }

        }
        static bool IsStudentExisting(List<Student> student, string firstName, string lastName)
        {
            foreach (Student person in student)
            {
                if (person.FirstName == firstName && person.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }
        static Student GetStudent(List<Student> student, string firstName, string lastName)
        {
            Student excistingStudent = null;
            foreach (Student person in student)
            {
                if (person.FirstName == firstName && person.LastName == lastName)
                {
                    excistingStudent = person;
                }
            }
            return excistingStudent;
        }
    }
    public class Student
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }

    }
}
