namespace _07._Order_by_Age
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            string command;
            List<Person> people = new List<Person>();
            while ((command = Console.ReadLine()) != "End")
            {
                string[] person = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string firstName = person[0];
                string personalID = person[1];
                int age = int.Parse(person[2]);
                Person newPerson = new Person(firstName, personalID, age);
                people.Add(newPerson);
            }
            people = people.OrderBy(x => x.Age).ToList();
            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
    public class Person
    {
        public Person(string firstName, string personalID, int age)
        {
            this.FirstName = firstName;
            this.PersonalID = personalID;
            this.Age = age;
        }

        public string FirstName { get; set; }

        public string PersonalID { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {

            return $"{FirstName} with ID: {PersonalID} is {Age} years old.";
        }
    }
}
