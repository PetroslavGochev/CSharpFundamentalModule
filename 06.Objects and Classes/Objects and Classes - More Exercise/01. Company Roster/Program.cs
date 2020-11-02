using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01._Company_Roster
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<Employee> listOfEmployee = new List<Employee>();
            for (int i = 1; i <= lines; i++)
            {
                string[] arrayOfEmployee = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = arrayOfEmployee[0];
                double salary = double.Parse(arrayOfEmployee[1]);
                string department = arrayOfEmployee[2];
                Employee person = new Employee(name, salary, department);
                listOfEmployee.Add(person);
            }
            string highDepartment = HighAverageSalary(listOfEmployee);
            Console.WriteLine(ReturnResult(listOfEmployee, highDepartment));
        }
        static string HighAverageSalary(List<Employee> listOfEmployee)
        {
            double highAverage = 0;
            string highDepartment = string.Empty;

            foreach (var person in listOfEmployee)
            {
                double salary = 0;
                int counter = 0;
                string department = person.Department;
                foreach (var item in listOfEmployee)
                {
                    if (item.Department == department)
                    {
                        salary += item.Salary;
                        counter++;
                    }
                }
                double average = salary / counter;
                if (average > highAverage)
                {
                    highAverage = average;
                    highDepartment = department;
                }
            }
            return highDepartment;

        }
        static string ReturnResult(List<Employee> listOfEmployee, string highDepartment)
        {
            StringBuilder result = new StringBuilder();
            listOfEmployee = listOfEmployee.OrderByDescending(x => x.Salary).ToList();
            result.AppendLine($"Highest Average Salary: {highDepartment}");
            foreach (var person in listOfEmployee)
            {
                if (person.Department == highDepartment)
                {
                    result.AppendLine($"{person.Name} {person.Salary:f2}");
                }
            }
            return result.ToString().TrimEnd();
        }
    }


    public class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
        public Employee(string name, double salary, string department)
        {
            this.Name = name;
            this.Salary = salary;
            this.Department = department;
        }
    }
}
}
