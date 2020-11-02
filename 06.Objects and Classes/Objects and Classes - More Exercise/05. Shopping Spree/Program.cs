using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05._Shopping_Spree
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] personFromConsole = Console.ReadLine()
                .Split(";", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string[] productFromConsole = Console.ReadLine()
                .Split(";", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            List<Person> listOfPersons = new List<Person>();
            List<Product> listOfProducts = new List<Product>();
            foreach (var person in personFromConsole)
            {
                string[] arrayOfPerson = person
                    .Split("=")
                    .ToArray();
                string name = arrayOfPerson[0];
                decimal money = decimal.Parse(arrayOfPerson[1]);
                Person newPerson = new Person(name, money);
                listOfPersons.Add(newPerson);
            }
            foreach (var product in productFromConsole)
            {
                string[] arrayOfProduct = product
                    .Split("=")
                    .ToArray();
                string nameOfProduct = arrayOfProduct[0];
                decimal priceOfProduct = decimal.Parse(arrayOfProduct[1]);
                Product addProduct = new Product(nameOfProduct, priceOfProduct);
                listOfProducts.Add(addProduct);
            }
            ReadCommandFromConsole(listOfPersons, listOfProducts);
        }
        static void ReadCommandFromConsole(List<Person> listOfPerson, List<Product> listOfProduct)
        {
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                decimal moneyOfPerson = 0;
                decimal moneyOfProduct = 0;
                string[] arrayOfCommand = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = arrayOfCommand[0];
                string product = arrayOfCommand[1];
                foreach (var priceOfProduct in listOfProduct)
                {
                    if (priceOfProduct.NameOfProduct == product)
                    {
                        moneyOfProduct = priceOfProduct.PriceOfProduct;
                    }
                }
                foreach (var person in listOfPerson)
                {
                    if (person.Name == name)
                    {
                        moneyOfPerson = person.Money;
                        if (moneyOfPerson >= moneyOfProduct)
                        {
                            person.BagOfProduct.Add(product);
                            person.Money -= moneyOfProduct;
                            Console.WriteLine($"{name} bought {product}");
                        }
                        else
                        {
                            Console.WriteLine($"{name} can't afford {product}");
                        }
                    }
                }
            }
            PrintResult(listOfPerson);
        }
        static void PrintResult(List<Person> listOfPerson)
        {
            foreach (var person in listOfPerson)
            {
                if (person.BagOfProduct.Count == 0)
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
                else
                {
                    Console.WriteLine(string.Join(Environment.NewLine, person));
                }

            }
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public decimal Money { get; set; }
        public List<string> BagOfProduct { get; set; }
        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.BagOfProduct = new List<string>();
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append($"{Name} - ");
            result.Append(string.Join(", ", BagOfProduct));
            //foreach (var product in BagOfProduct)
            //{
            //    result.Append($"{product}, ");
            //}
            return result.ToString().TrimEnd();
        }
    }
    public class Product
    {
        public string NameOfProduct { get; set; }
        public decimal PriceOfProduct { get; set; }
        public Product(string nameOfProduct, decimal priceOfProduct)
        {
            this.NameOfProduct = nameOfProduct;
            this.PriceOfProduct = priceOfProduct;
        }
    }
}

