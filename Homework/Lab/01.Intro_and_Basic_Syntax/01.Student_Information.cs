using System;

namespace _01.Student_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentsName = Console.ReadLine();
            int studentAge = int.Parse(Console.ReadLine());
            double studentMark = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {studentsName}, Age: {studentAge}, Grade: {studentMark:f2}");
        }
    }
}
