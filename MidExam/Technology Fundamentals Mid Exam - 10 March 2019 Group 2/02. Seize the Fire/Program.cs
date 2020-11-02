using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02._Seize_the_Fire
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfFire = Console.ReadLine()
                .Split("#", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            int water = int.Parse(Console.ReadLine());
            List<int> fireCell = new List<int>();
            double effort = 0;
            int totalFire = 0;
            foreach (var fires in listOfFire)
            {
                string[] fire = fires
                    .Split(" = ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string typeOfFyre = fire[0];
                int sizeOfFire = int.Parse(fire[1]);
                if(sizeOfFire > water)
                {
                    continue;
                }
                if (typeOfFyre == "High")
                {
                    if (sizeOfFire < 81 || sizeOfFire > 125)
                    {
                        continue;
                    }
                }
                else if (typeOfFyre == "Medium")
                {
                    if (sizeOfFire < 51 || sizeOfFire > 80)
                    {
                        continue;
                    }
                }
                else if (typeOfFyre == "Low")
                {
                    if(sizeOfFire < 1 || sizeOfFire > 50)
                    {
                        continue;
                    }
                }
                    water -= sizeOfFire;
                    totalFire += sizeOfFire;
                    effort += sizeOfFire * 0.25;
                    fireCell.Add(sizeOfFire);  
            }
           Console.WriteLine(PrintResult(fireCell, totalFire, effort));
        }
        static string PrintResult(List<int> fireCell, int totalFire, double effort)
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Cells:");
            foreach (var fire in fireCell)
            {
                result.AppendLine($"- {fire}");
            }
            result.AppendLine($"Effort: {effort:F2}");
            result.Append($"Total Fire: {totalFire}");
            return result.ToString();
        }
       
    }
}
