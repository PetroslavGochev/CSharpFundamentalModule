using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vehicle_Catalogue
{
    class Program
    {
        public static void Main(string[] args)
        {
            string command;
            Catalog catalogList = new Catalog();
            while ((command = Console.ReadLine()) != "end")
            {
                string[] vehicle = command.Split("/").ToArray();
                if (vehicle[0] == "Car")
                {
                    Car car = new Car()
                    {
                        Brand = vehicle[1],
                        Model = vehicle[2],
                        HoursePower = int.Parse(vehicle[3])
                    };
                    catalogList.Cars.Add(car);
                }
                else if (vehicle[0] == "Truck")
                {
                    Truck truck = new Truck()
                    {
                        Brand = vehicle[1],
                        Model = vehicle[2],
                        Weight = int.Parse(vehicle[3])
                    };
                    catalogList.Trucks.Add(truck);
                }
            }
            SortedList(catalogList);
        }

        static void SortedList(Catalog catalog)
        {
            if (catalog.Cars.Count > 0)
            {
                Console.WriteLine($"Cars:");
                foreach (Car car in catalog.Cars.OrderBy(c => c.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HoursePower}hp");
                }
            }
            if (catalog.Trucks.Count > 0)
            {
                Console.WriteLine($"Trucks:");
                foreach (Truck truck in catalog.Trucks.OrderBy(c => c.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }

        public class Catalog
        {
            public Catalog()
            {
                this.Cars = new List<Car>();
                this.Trucks = new List<Truck>();
            }
            public List<Truck> Trucks { get; set; }
            public List<Car> Cars { get; set; }
        }

        public class Truck
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int Weight { get; set; }
        }
        public class Car
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int HoursePower { get; set; }
        }
    }
}
