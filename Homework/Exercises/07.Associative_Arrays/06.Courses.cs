using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> coursesInfo = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string courseName = input.Split(" : ")[0];
                string studentName = input.Split(" : ")[1];

                if (!coursesInfo.ContainsKey(courseName))
                {
                    coursesInfo.Add(courseName, new List<string>());
                    coursesInfo[courseName].Add(studentName);
                }
                else
                {
                    coursesInfo[courseName].Add(studentName);
                }

                input = Console.ReadLine();
            }

            foreach (var pair in coursesInfo.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{pair.Key}: {pair.Value.Count}");

                foreach (var studentName in pair.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {studentName}");
                }
            }
        }
    }
}
