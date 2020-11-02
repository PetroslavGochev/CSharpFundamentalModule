using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06._Vehicle_Catalogue
{
    class Program
    {
        public static void Main(string[] args)
        {
            string command;
            List<Vehicle> catalogue = new List<Vehicle>();
            while ((command = Console.ReadLine()) != "End")
            {
                string[] vehicle = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string type = vehicle[0];
                string model = vehicle[1];
                string color = vehicle[2];
                double horsePower = double.Parse(vehicle[3]);
                Vehicle newVehicle = new Vehicle(type, model, color, horsePower);
                catalogue.Add(newVehicle);

            }
            while ((command = Console.ReadLine()) != "Close the Catalogue")
            {
                if (catalogue.Any(x => x.Model.Contains(command)))
                {
                    int index = catalogue.FindIndex(x => x.Model.Contains(command));
                    Console.WriteLine(catalogue[index]);
                }
            }
            if (catalogue.Any(x => x.TypeOfVehicle.Contains("car")))
            {
                Console.WriteLine($"Cars have average horsepower of: {AverageHorsePower("car", catalogue):F2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:F2}.");
            }
            if (catalogue.Any(x => x.TypeOfVehicle.Contains("truck")))
            {
                Console.WriteLine($"Trucks have average horsepower of: {AverageHorsePower("truck", catalogue):F2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:F2}.");
            }



            static double AverageHorsePower(string type, List<Vehicle> catalogue)
            {
                double totalPower = 0;
                int counter = 0;
                foreach (Vehicle vehicle in catalogue)
                {
                    if (vehicle.TypeOfVehicle == type)
                    {
                        totalPower += vehicle.HorsePower;
                        counter++;
                    }
                }

                totalPower /= counter;

                return totalPower;
            }

        }
    }

    public class Vehicle
    {
        public string TypeOfVehicle { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double HorsePower { get; set; }

        public Vehicle(string type, string model, string color, double horsePower)
        {
            this.TypeOfVehicle = type;
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;
        }
        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine($"Type: {char.ToUpper(TypeOfVehicle[0]) + TypeOfVehicle.Substring(1)}");
            text.AppendLine($"Model: {this.Model}");
            text.AppendLine($"Color: {this.Color}");
            text.Append($"Horsepower: {this.HorsePower}");
            return text.ToString();
        }
    }
}
