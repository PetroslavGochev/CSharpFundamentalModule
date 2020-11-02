using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace _04._Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> dictOfDwarf = new Dictionary<string, Dictionary<string, int>>();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Once upon a time")
            {
                string[] input = command
                    .Split(new char[] { ' ', ' ', '<', ':', '>' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string dwarfHatColors = input[1];
                string nameOfDwarf = input[0];
                int dwarfPhysics = int.Parse(input[2]);
                if (dictOfDwarf.ContainsKey(dwarfHatColors))
                {
                    if (dictOfDwarf[dwarfHatColors].ContainsKey(nameOfDwarf))
                    {
                        if (dictOfDwarf[dwarfHatColors][nameOfDwarf] < dwarfPhysics)
                        {
                            dictOfDwarf[dwarfHatColors][nameOfDwarf] = dwarfPhysics;
                        }
                    }
                    else
                    {
                        dictOfDwarf[dwarfHatColors].Add(nameOfDwarf, dwarfPhysics);
                    }
                }
                else
                {
                    dictOfDwarf.Add(dwarfHatColors, new Dictionary<string, int>());
                    dictOfDwarf[dwarfHatColors].Add(nameOfDwarf, dwarfPhysics);
                }
            }
            Console.WriteLine(PrintResult(dictOfDwarf));
        }
        static string PrintResult(Dictionary<string, Dictionary<string, int>> dictOfDwarf)
        {
            StringBuilder result = new StringBuilder();
            Dictionary<string, int> sortedDict = new Dictionary<string, int>(); 
            foreach (var hatColor in dictOfDwarf.OrderByDescending(x=>x.Value.Count()))
            {
                foreach (var dwarf in hatColor.Value)
                {
                    sortedDict.Add($"({hatColor.Key}) {dwarf.Key} <-> ", dwarf.Value);
                }
            }
            foreach (var dwarf in sortedDict.OrderByDescending(x=>x.Value))
            {
                result.AppendLine($"{dwarf.Key}{dwarf.Value}");
            }
            return result.ToString().Trim();
        }
    }
}