using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Raw_Data
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
                Car car = new Car(carModel);
                Engine carEngine = new Engine(int.Parse(carModel[1]), int.Parse(carModel[2]));
                Cargo carCargo = new Cargo(int.Parse(carModel[3]), carModel[4]);
                car.Cargo.Add(carCargo);
                car.Engine.Add(carEngine);
                listOfCars.Add(car);
            }
            string action = Console.ReadLine();
            if (action == "flamable")
            {
                foreach (var car in listOfCars)
                {
                    bool type = false;
                    bool power = false;
                    foreach (var typeOfCargo in car.Cargo)
                    {
                        if (typeOfCargo.CargoType == action)
                        {
                            type = true;
                        }
                    }
                    foreach (var enginePower in car.Engine)
                    {
                        if (enginePower.EnginePower > 250)
                        {
                            power = true;
                        }
                    }
                    if (type && power)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
            else if (action == "fragile")
            {
                foreach (var car in listOfCars)
                {
                    bool type = false;
                    bool weight = false;
                    foreach (var typeOfCargo in car.Cargo)
                    {
                        if (typeOfCargo.CargoType == action)
                        {
                            type = true;
                        }
                    }
                    foreach (var weightOfCargo in car.Cargo)
                    {
                        if (weightOfCargo.CargoWeight < 1000)
                        {
                            weight = true;
                        }
                    }
                    if (type && weight)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
        }
        public class Car
        {
            public string Model { get; set; }
            public List<Engine> Engine { get; set; }
            public List<Cargo> Cargo { get; set; }
            public Car(string[] car)
            {
                this.Model = car[0];
                this.Engine = new List<Engine>();
                this.Cargo = new List<Cargo>();
            }
            public override string ToString()
            {
                string result = Model;
                return result;
            }
        }
        public class Engine
        {
            public int EngineSpeed { get; set; }
            public int EnginePower { get; set; }
            public Engine(int engineSpeed, int enginePower)
            {
                this.EngineSpeed = engineSpeed;
                this.EnginePower = enginePower;
            }
        }
        public class Cargo
        {
            public int CargoWeight { get; set; }
            public string CargoType { get; set; }
            public Cargo(int cargoWeight, string cargoType)
            {
                this.CargoType = cargoType;
                this.CargoWeight = cargoWeight;
            }
        }
    }
}
