using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> studentResult = new Dictionary<string, int>();
            Dictionary<string, int> languageData = new Dictionary<string, int>();
            string command;
            while ((command = Console.ReadLine()) != "exam finished")
            {
                if (command.Contains("banned"))
                {
                    string[] banned = command
                        .Split("-", StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();
                    string nameOfStudent = banned[0];
                    if (studentResult.ContainsKey(nameOfStudent))
                    {
                        studentResult.Remove(nameOfStudent);
                    }
                }
                else
                {
                    string[] receiveStudent = command
                        .Split("-", StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();
                    string nameOfStudent = receiveStudent[0];
                    string language = receiveStudent[1];
                    int point = int.Parse(receiveStudent[2]);
                    if (languageData.ContainsKey(language))
                    {
                        languageData[language]++;
                    }
                    else
                    {
                        languageData.Add(language, 1);
                    }
                    if (studentResult.ContainsKey(nameOfStudent))
                    {
                        if (studentResult[nameOfStudent] < point)
                        {
                            studentResult[nameOfStudent] = point;
                        }
                    }
                    else
                    {
                        studentResult.Add(nameOfStudent, point);
                    }
                }
            }
            studentResult = studentResult.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);
            languageData = languageData.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);
            Console.WriteLine("Results:");
            foreach (var data in studentResult)
            {
                Console.WriteLine($"{data.Key} | {data.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var data in languageData)
            {
                Console.WriteLine($"{data.Key} - {data.Value}");
            }
        }
    }
}
