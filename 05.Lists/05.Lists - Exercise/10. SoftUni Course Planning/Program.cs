using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    class Program
    {
        static List<string> ReturnList()
        {
            List<string> list = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            return list;
        }
        static void Main(string[] args)
        {
            var list = ReturnList();
            Command(list);
            for (int i = 1; i <= list.Count; i++)
            {
                Console.WriteLine($"{i}.{list[i - 1]}");
            }
        }
        static List<string> Command(List<string> listWithLessons)
        {
            string command;
            while ((command = Console.ReadLine()) != "course start")
            {
                string[] arrayCommand = command.Split(":").ToArray();
                if (arrayCommand[0] == "Add")
                {
                    AddLessonsInList(listWithLessons, arrayCommand[1]);
                }
                else if (arrayCommand[0] == "Insert")
                {
                    InsertLessonInList(listWithLessons, arrayCommand[1], int.Parse(arrayCommand[2]));
                }
                else if (arrayCommand[0] == "Remove")
                {
                    RemoveLessons(listWithLessons, arrayCommand[1]);
                }
                else if (arrayCommand[0] == "Swap")
                {
                    SwapLessons(listWithLessons, arrayCommand[1], arrayCommand[2]);
                }
                else if (arrayCommand[0] == "Exercise")
                {
                    AddLessonsExercise(listWithLessons, arrayCommand[1]);
                }
            }
            return listWithLessons;
        }
        static List<string> AddLessonsInList(List<string> list, string lessons)
        {
            if (!list.Contains(lessons))
            {
                list.Add(lessons);
            }
            return list;
        }
        static List<string> InsertLessonInList(List<string> list, string lessons, int index)
        {
            if (!list.Contains(lessons))
            {
                list.Insert(index, lessons);
            }
            return list;
        }
        static List<string> RemoveLessons(List<string> list, string lessons)
        {
            list.Remove(lessons);
            list.Remove($"{lessons}-Exercise");
            return list;
        }
        static List<string> SwapLessons(List<string> list, string firstLessons, string secondLessons)
        {
            string firstText = firstLessons;
            string secondText = secondLessons;
            if (list.Contains(firstLessons) && list.Contains(secondLessons))
            {
                int indexFirst = list.IndexOf(firstLessons);
                int indexSecond = list.IndexOf(secondLessons);
                string temp = firstText;
                list[indexFirst] = secondText;
                list[indexSecond] = firstText;
            }
            string firstTextExercise = $"{firstLessons}-Exercise";
            string secondTextExercise = $"{secondLessons}-Exercise";
            if (list.Contains(firstTextExercise))
            {
                int indexExercise = list.IndexOf(firstTextExercise);
                int index = list.IndexOf(firstText);
                list.Insert(index + 1, firstTextExercise);
                list.RemoveAt(indexExercise);
            }
            if (list.Contains(secondTextExercise))
            {
                int indexExercise = list.IndexOf(secondTextExercise);
                int index = list.IndexOf(secondText);
                list.RemoveAt(indexExercise);
                list.Insert(index + 1, secondTextExercise);
            }
            return list;
        }
        static List<string> AddLessonsExercise(List<string> list, string lessons)
        {
            if (list.Contains(lessons) && !list.Contains($"{lessons}-Exercise"))
            {
                list.Insert(list.IndexOf(lessons) + 1, $"{lessons}-Exercise");
            }
            else if (!list.Contains(lessons))
            {
                list.Add(lessons);
                list.Add($"{lessons}-Exercise");
            }
            return list;
        }
    }
}
