using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Oldest_Family_Member
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            Family listOfFamily = new Family();
            for (int i = 1; i <= lines; i++)
            {
                string[] people = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = people[0];
                int age = int.Parse(people[1]);
                Person familyName = new Person(name, age);
                listOfFamily.Person.Add(familyName);
            }
            Person family = ReturnOldestFamily(listOfFamily);
            Console.WriteLine($"{family.Name} {family.Age}");
        }
        static Person ReturnOldestFamily(Family listOfFamily)
        {
            Person oldestFamily = listOfFamily.Person.OrderByDescending(x => x.Age).FirstOrDefault();
            return oldestFamily;
        }

    }
    public class Family
    {
        public List<Person> Person { get; set; }
        public Family()
        {
            this.Person = new List<Person>();
        }

    }
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}

