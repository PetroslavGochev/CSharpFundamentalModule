using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
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

                Student person = new Student();
                person.FirstName = firstName;
                person.LastName = lastName;
                person.Age = age;
                person.HomeTown = homeTown;

                students.Add(person);
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
    }
    public class Student
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}
