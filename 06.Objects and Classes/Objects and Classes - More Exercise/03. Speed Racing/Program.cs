using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03._Speed_Racing
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> listOfCars = new List<Car>();
            for (int i = 1; i <= numberOfCars; i++)
            {
                string[] carModel = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string model = carModel[0];
                double fuelAmount = double.Parse(carModel[1]);
                double fuelPerKilometer = double.Parse(carModel[2]);
                Car car = new Car(model, fuelAmount, fuelPerKilometer);
                listOfCars.Add(car);
            }
            ReceiveCommand(listOfCars);
        }
        static void ReceiveCommand(List<Car> listOfCars)
        {
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] modelOfCar = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string model = modelOfCar[1];
                double travel = double.Parse(modelOfCar[2]);
                foreach (var car in listOfCars)
                {
                    if (car.Model == model)
                    {
                        car.TraveledDistance(car, travel);

                    }
                }
            }
            PrintRersult(listOfCars);
        }
        static void PrintRersult(List<Car> listOfCars)
        {
            Console.WriteLine(string.Join(Environment.NewLine, listOfCars));
        }

    }
    public class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelPerKilometer { get; set; }
        public double TraveledKilometer { get; set; }
        public Car(string model, double fuel, double fuelPerKm)
        {
            this.Model = model;
            this.FuelAmount = fuel;
            this.FuelPerKilometer = fuelPerKm;
            this.TraveledKilometer = 0;
        }
        public Car TraveledDistance(Car model, double distance)
        {
            double spentFuel = model.FuelPerKilometer * distance;
            if (model.FuelAmount >= spentFuel)
            {
                model.TraveledKilometer += distance;
                model.FuelAmount -= spentFuel;
                return model;
            }
            Console.WriteLine($"Insufficient fuel for the drive");
            return model;
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append($"{Model} {FuelAmount:f2} {TraveledKilometer}");
            return result.ToString();
        }
    }
}
