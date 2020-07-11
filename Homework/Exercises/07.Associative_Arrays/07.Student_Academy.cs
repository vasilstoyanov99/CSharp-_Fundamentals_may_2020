using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInput = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> studentsGradesInfo = new Dictionary<string, List<double>>();

            for (int i = 0; i < numberOfInput; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());

                if (!studentsGradesInfo.ContainsKey(studentName))
                {
                    studentsGradesInfo.Add(studentName, new List<double>());
                    studentsGradesInfo[studentName].Add(studentGrade);
                }
                else
                {
                    studentsGradesInfo[studentName].Add(studentGrade);
                }
            }

            Dictionary<string, double> averageResults = new Dictionary<string, double>();

            foreach (var pair in studentsGradesInfo)
            {
                averageResults.Add(pair.Key, pair.Value.Average());
            }

            foreach (var pair in averageResults.Where(x => x.Value >= 4.50).OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value:f2}");
            }
        }
    }
}
