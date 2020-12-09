using System;
using System.Collections.Generic;
using System.Linq;

namespace Need_for_Speed_III
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            FillDictionary(cars, int.Parse(Console.ReadLine()));
            string input = string.Empty;
            while((input = Console.ReadLine()) != "Stop")
            {
                string[] data = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                var command = data[0];
                if (command == "Drive") Drive(cars, data);
                else if (command == "Refuel") Refuel(cars, data);
                else if (command == "Revert") Revert(cars, data);
            }
            PrintResult(cars);
        }
        static public void FillDictionary(List<Car> cars,int number)
        {
            for (int i = 1; i <= number; i++)
            {
                var input = Console.ReadLine()
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);
                var model = input[0];
                var mileage = double.Parse(input[1]);
                var fuel = double.Parse(input[2]);
                Car car = new Car( model,fuel, mileage);
                cars.Add(car);
            }
        }
        static public void Drive(List<Car> cars,string[] input)
        {
            var model = input[1];
            var distance = double.Parse(input[2]);
            var fuel = double.Parse(input[3]);
            for (int i = 0; i < cars.Count;i++)
            {
                if(cars[i].Model == model)
                {
                    if(cars[i].Fuel >= fuel)
                    {
                        cars[i].Mileage += distance;
                        cars[i].Fuel -= fuel;
                        Console.WriteLine($"{cars[i].Model} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                        if(cars[i].Mileage >= 100000)
                        {
                            Console.WriteLine($"Time to sell the {cars[i].Model}!");
                            cars.RemoveAt(i);
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                        break;
                    }
                }
            }
        }
        static public void Refuel(List<Car> cars,string[] input)
        {
            var model = input[1];
            var fuel = double.Parse(input[2]);
            foreach (var car in cars)
            {
                if(car.Model == model)
                {
                    if(car.Fuel + fuel > 75)
                    {
                        fuel = 75 - car.Fuel;
                        car.Fuel = 75;
                    }
                    else
                    {
                        car.Fuel += fuel;
                    }
                    Console.WriteLine($"{car.Model} refueled with {fuel} liters");
                    break;
                }
            }
        }
        static void Revert(List<Car> cars, string[] input)
        {
            var model = input[1];
            var kilometers = double.Parse(input[2]);
            foreach (var car in cars)
            {
                if(car.Model == model)
                {
                    if(car.Mileage - kilometers >= 10000)
                    {
                        Console.WriteLine($"{car.Model} mileage decreased by {kilometers} kilometers");
                        car.Mileage -= kilometers;
                    }
                    else
                    {
                        car.Mileage = 10000;
                    }
                }
            }
        }
        static void PrintResult(List<Car> cars)
        {
            foreach (var car in cars.OrderByDescending(x=>x.Mileage).ThenBy(x=>x.Model))
            {
                Console.WriteLine(car);
            }
        }
    }
    public class Car
    {
        public Car(string model,double fuel,double mileage)
        {
            this.Model = model;
            this.Mileage = mileage;
            this.Fuel = fuel;
        }
        public string Model { get; set; }
        public double Fuel { get; set; }
        public double Mileage { get; set; }
        public override string ToString()
        {
            return $"{this.Model} -> Mileage: {this.Mileage} kms, Fuel in the tank: {this.Fuel} lt.";
        }
    }
}
