using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());
            List<Students> allStudents = new List<Students>();

            for (int curStudent = 0; curStudent < countOfStudents; curStudent++)
            {
                string[] newStudentInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                Students newStudent = new Students();
                newStudent.FistName = newStudentInfo[0];
                newStudent.LastName = newStudentInfo[1];
                newStudent.Grade = double.Parse(newStudentInfo[2]);
                allStudents.Add(newStudent);
            }

            List<Students> sorted = allStudents.OrderBy(j => j.Grade).ToList();
            sorted.Reverse();

            foreach (var currStudent in sorted)
            {
                Console.WriteLine($"{currStudent.FistName} {currStudent.LastName}: {currStudent.Grade:f2}");
            }
        }

        class Students
        {
            public string FistName { get; set; }
            public string LastName { get; set; }
            public double Grade { get; set; }
        }
    }
}
