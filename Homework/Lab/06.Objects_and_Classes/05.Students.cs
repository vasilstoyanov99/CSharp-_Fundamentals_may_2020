using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace _05.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Student> allStudentsInfo = new List<Student>();

            while (input != "end")
            {
                string[] currStidentData = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                Student newStudent = new Student();
                newStudent.FisrtName = currStidentData[0];
                newStudent.LastName = currStidentData[1];
                newStudent.Age = currStidentData[2];
                newStudent.Hometown = currStidentData[3];
                allStudentsInfo.Add(newStudent);

                input = Console.ReadLine();
            }

            string printStudentsFrom = Console.ReadLine();

            foreach (var currStudentInfo in allStudentsInfo)
            {
                if (currStudentInfo.Hometown == printStudentsFrom)
                {
                    Console.WriteLine($"{currStudentInfo.FisrtName} {currStudentInfo.LastName} is {currStudentInfo.Age} years old.");
                }
            }
        }

        public class Student
        {
           public string FisrtName { get; set; }
           public string LastName { get; set; }
           public string Age { get; set; }
           public string Hometown { get; set; }
        }
    }
}
