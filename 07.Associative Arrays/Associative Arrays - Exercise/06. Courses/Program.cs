using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Course> listOfCourses = new List<Course>();

            Dictionary<string, List<string>> coursesDict = new Dictionary<string, List<string>>();
            ReceiveCourse(coursesDict);
            foreach (var course in coursesDict)
            {
                Course courses = new Course(course.Key, course.Value);
                listOfCourses.Add(courses);
            }
            listOfCourses = listOfCourses
                .OrderByDescending(x => x.Students.Count)
                .ToList();
            Console.WriteLine(String.Join(Environment.NewLine, listOfCourses));

        }

        static void ReceiveCourse(Dictionary<string, List<string>> coursesDict)
        {
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] course = command
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string nameOfcourse = course[0];
                string nameOfStudents = course[1];
                if (coursesDict.ContainsKey(nameOfcourse))
                {
                    coursesDict[nameOfcourse].Add(nameOfStudents);
                }
                else
                {
                    coursesDict.Add(nameOfcourse, new List<string>());
                    coursesDict[nameOfcourse].Add(nameOfStudents);
                }
            }
        }
    }

    public class Course
    {
        public Course(string courseName, List<string> students)
        {
            this.NameOfCourse = courseName;
            this.Students = new List<string>();
            foreach (var student in students)
            {
                Students.Add(student);
            }
            Students = Students.OrderBy(x => x).ToList();

        }
        public string NameOfCourse { get; set; }
        public List<string> Students { get; set; }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"{NameOfCourse}: {Students.Count}");
            foreach (var student in Students)
            {
                result.AppendLine($"-- {student}");
            }

            return result.ToString().TrimEnd();
        }
    }
}
